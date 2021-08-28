using System.Collections.Generic;

namespace Application.Wrappers
{
    public class PagedListResponse<T>
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public IList<T> Items { get; set; }
    }
}
