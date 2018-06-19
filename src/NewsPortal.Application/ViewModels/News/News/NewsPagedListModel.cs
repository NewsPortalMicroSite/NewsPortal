
using NewsPortal.Domain.Common.Interface;
using System;

namespace NewsPortal.Application.ViewModels.News
{
    public class NewsPagedListModel
    {
        public IPagedList<NewsSummary> ListNews { get; set; }

        public class NewsSummary
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Tags { get; set; }
            public string Author { get; set;}
            public string Picture { get; set; }
            public DateTime? PublishingDate { get; set; }
        }
    }
}
