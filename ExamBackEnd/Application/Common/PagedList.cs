using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Common
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public PagedList(List<T> items, int count, int pageIndex, int itemsPerPage)
        {
            TotalCount = count;
            CurrentPage = pageIndex;
            PageSize = itemsPerPage;            
            TotalPages = (int)Math.Ceiling(count / (double)itemsPerPage);

            AddRange(items);
        }

        public static PagedList<T> Create(IEnumerable<T> source, int pageIndex, int itemsPerPage)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            return new PagedList<T>(items, count, pageIndex, itemsPerPage);
        }
    }
}
