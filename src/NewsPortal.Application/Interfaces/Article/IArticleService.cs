using NewsPortal.Application.ViewModels;
using System.Collections.Generic;
using NewsPortal.Application.ViewModels.Article;

namespace NewsPortal.Application.Interfaces.Article
{
    public interface IArticleService
    {

        #region Web

        List<ArticleWebListModel> GetWebListModel(int count = 0);
        ArticleWebModel GetWebModel(int id);

        #endregion

        List<ArticleListModel> List();        
        ArticlePagedListModel PagedList(PagingCommand command);
        int AddOrUpdate(ArticleAddUpdateModel model);
        ArticleAddUpdateModel Get(int id); 
        ArticleAddUpdateModel Edit();
        void Delete(int id);
        bool RemovePicture(int id);
    }
}
