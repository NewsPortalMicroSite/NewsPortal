using NewsPortal.Application.ViewModels;
using NewsPortal.Application.ViewModels.News;
using System.Collections.Generic;
 
namespace NewsPortal.Application.Interfaces.News
{
    public interface INewsService
    {

        #region Web

        List<NewsWebListModel> GetWebListModel(int count = 0);
        NewsWebModel GetWebModel(int id);

        #endregion

        List<NewsListModel> List();
        
        NewsPagedListModel PagedList(PagingCommand command);
        int AddOrUpdate(NewsAddUpdateModel model);
        NewsAddUpdateModel Get(int id); 
        NewsAddUpdateModel Edit();
        void Delete(int id);
        bool RemovePicture(int id);
    }
}
