using System;
using SlackCleanup.SlackApiImplementation.Model.Requests;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class SearchApi : ISearchApi
    {
        private readonly IRequestHandler _request;

        public SearchApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public SearchResponse All(string queryString, SearchSortType? sortType = null,
            SortDirection? sortDir = null, bool? isHighlighted = null, int? messageCount = null,
            int? pageNumber = null)
        {
            string highlighted = null;

            if (isHighlighted.HasValue)
                highlighted = isHighlighted.Value ? "1" : "0";

            var apiPath = _request.BuildApiPath("/search.all",
                                        query => queryString,
                                        sort => sortType,
                                        sort_dir => sortDir,
                                        highlight => highlighted,
                                        count => messageCount,
                                        page => pageNumber);

            var response = _request.ExecuteAndDeserializeRequest<SearchResponse>(apiPath);

            return response;
        }

        public SearchResponse Files(string queryString, SearchSortType? sortType = null,
            SortDirection? sortDir = null, bool? isHighlighted = null, int? messageCount = null,
            int? pageNumber = null)
        {
            string highlighted = null;

            if (isHighlighted.HasValue)
                highlighted = isHighlighted.Value ? "1" : "0";

            var apiPath = _request.BuildApiPath("/search.files",
                                        query => queryString,
                                        sort => sortType,
                                        sort_dir => sortDir,
                                        highlight => highlighted,
                                        count => messageCount,
                                        page => pageNumber);

            var response = _request.ExecuteAndDeserializeRequest<SearchResponse>(apiPath);

            return response;
        }

        public SearchResponse Messages(string queryString, SearchSortType? sortType = null,
            SortDirection? sortDir = null, bool? isHighlighted = null, int? messageCount = null,
            int? pageNumber = null)
        {
            string highlighted = null;

            if (isHighlighted.HasValue)
                highlighted = isHighlighted.Value ? "1" : "0";

            var apiPath = _request.BuildApiPath("/search.messages",
                                        query => queryString,
                                        sort => sortType,
                                        sort_dir => sortDir,
                                        highlight => highlighted,
                                        count => messageCount,
                                        page => pageNumber);

            var response = _request.ExecuteAndDeserializeRequest<SearchResponse>(apiPath);

            return response;
        }
    }
}
