using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Application.ViewModels.NewsComment
{
    public class NewsCommentWebModel
    {
        public int NewsId { get; set; }
        public int EmployeeId { get; set; }
        public string Comment { get; set; }
    }
}
