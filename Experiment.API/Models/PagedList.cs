using Experiment.API.Controllers;

namespace Experiment.API.Models
{
    /// <summary>
    /// https://code-maze.com/paging-aspnet-core-webapi/
    /// </summary>
    public class PagedList<T> : List<T>
    {
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public int CurrentPage { get; private set; }
        public bool HasNext => CurrentPage < TotalPages;
        public bool HasPrevious => CurrentPage > 1;
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }

        public static PagedList<T2> ToPagedList<T2>(IQueryable<T2> data, QueryStringParameters filter)
        {
            var filteredData = data
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize);
            return new PagedList<T2>(filteredData.ToList(), data?.Count() ?? 0, filter.PageSize, filter.PageNumber);
        }
    }
}