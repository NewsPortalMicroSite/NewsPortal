using System.Collections;
using System.Collections.Generic;

namespace NewsPortal.Domain.Common.Interface
{
    public interface IPagedList : IEnumerable
    {
        int PageIndex { get; }
        int PageSize { get; }
        int TotalCount { get; }
        int TotalPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }

        bool HasResults { get; }
        int Page { get; }
    }

    public interface IPagedList<T> : IPagedList, IList<T>
    {
    }
}
