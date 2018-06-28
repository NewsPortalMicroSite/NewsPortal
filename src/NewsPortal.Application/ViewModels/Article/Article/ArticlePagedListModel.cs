
using NewsPortal.Domain.Common.Interface;
using System;

namespace NewsPortal.Application.ViewModels.Article
{
    public class ArticlePagedListModel
    {
        public IPagedList<ArticleSummary> ListArticle { get; set; }

        public class ArticleSummary
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
