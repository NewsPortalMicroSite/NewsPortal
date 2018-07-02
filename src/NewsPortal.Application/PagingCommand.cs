using NewsPortal.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Application
{
    public class PagingCommand
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public UserType UserType { get; set; }
         
        /// <summary>
        /// Creates a new <see cref="PagingCommand"/> instance.
        /// </summary>
        public PagingCommand()
        {
            // set up sensible defaults. Page index is 1 based for consumer
            Page = 1;
            PageSize = 10;
        }

        /// <summary>
        /// Returns the zero based page index
        /// </summary>
        public int PageIndex
        {
            get
            {
                return Page > 0 ? Page - 1 : 0;
            }
        }
    }
}
