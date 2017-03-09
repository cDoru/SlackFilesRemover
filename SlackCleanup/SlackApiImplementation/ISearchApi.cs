using SlackCleanup.SlackApiImplementation.Model.Requests;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface ISearchApi
    {
        SearchResponse All(string queryString, SearchSortType? sortType = null,
            SortDirection? sortDir = null, bool? isHighlighted = null, int? messageCount = null,
            int? pageNumber = null);
        SearchResponse Files(string queryString, SearchSortType? sortType = null,
            SortDirection? sortDir = null, bool? isHighlighted = null, int? messageCount = null,
            int? pageNumber = null);
        SearchResponse Messages(string queryString, SearchSortType? sortType = null,
            SortDirection? sortDir = null, bool? isHighlighted = null, int? messageCount = null,
            int? pageNumber = null);
    }
}
