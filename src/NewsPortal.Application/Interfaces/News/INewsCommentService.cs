﻿
using NewsPortal.Application.ViewModels.NewsComment;
using System.Collections.Generic;
 

namespace NewsPortal.Application.Interfaces.News
{
    public interface INewsCommentService
    {
        bool AddCommentToNews(NewsCommentWebModel model);

        List<NewsCommentWebModel> GetAllNewsComments(NewsCommentWebModel model);

        int GetTotalComments();
    }
}