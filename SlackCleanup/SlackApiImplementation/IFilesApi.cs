using SlackCleanup.SlackApiImplementation.Model.Requests;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IFilesApi
    {
        ResponseBase Delete(string fileId);
        FileResponse Info(string fileId, int commentsCount = 100, int pageNumber = 1);
        FilesResponse List(FilesListRequest request);
        FileResponse Upload(FileUploadRequest request);
    }
}
