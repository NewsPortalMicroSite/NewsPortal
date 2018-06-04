using NewsPortal.Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortal.Data.Common
{
    public class PagedList<T> : List<T>, IPagedList<T>
    {
        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            TotalCount = totalCount;
            TotalPages = totalCount / pageSize;

            if (totalCount % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;

            AddRange(source.ToList());
        }

        public int PageIndex { get; }
        public int PageSize { get; }
        public int TotalCount { get; }
        public int TotalPages { get; }

        public bool HasPreviousPage => (PageIndex > 0);
        public bool HasNextPage => (PageIndex + 1 < TotalPages);

        public bool HasResults => TotalCount > 0;
        public int Page => PageIndex + 1; // For display purposes
    }
}
