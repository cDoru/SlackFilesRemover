using System;
using SlackCleanup.SlackApiImplementation.Model.Requests;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class FilesApi : IFilesApi
    {
        private readonly IRequestHandler _request;

        public FilesApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public ResponseBase Delete(string fileId)
        {
            var apiPath = _request.BuildApiPath("/files.delete", file => fileId);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }

        public FileResponse Info(string fileId, int commentsCount = 100, int pageNumber = 1)
        {
            var apiPath = _request.BuildApiPath("/files.info",
                                       file => fileId,
                                       count => commentsCount.ToString(),
                                       page => pageNumber.ToString()
                                      );
            var response = _request.ExecuteAndDeserializeRequest<FileResponse>(apiPath);

            return response;
        }

        public FilesResponse List(FilesListRequest request)
        {
            var requestParams = _request.BuildRequestParams(request);
            var response = _request.ExecuteAndDeserializeRequest<FilesResponse>("/files.list", requestParams);

            return response;
        }

        public FileResponse Upload(FileUploadRequest request)
        {
            var requestParams = _request.BuildRequestParams(request);
            var response = _request.ExecuteAndDeserializeRequest<FileResponse>("/files.upload", requestParams, file: request);

            return response;
        }
    }
}
