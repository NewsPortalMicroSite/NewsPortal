
using NewsPortal.Infrastructure.CrossCutting.Constants;
using NewsPortal.Application.Interfaces.Article;
using NewsPortal.Application.ViewModels;
using NewsPortal.Application.ViewModels.Article; 
using NewsPortal.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArticlePortal.Application.Services
{
    //public class ArticleAppServices : IArticleService
    //{
    //    private readonly IArticleRepository _articleRepository;

    //    //public ArticleAppServices(IArticleRepository articleRepository)
    //    //{
    //    //    _articleRepository = articleRepository;
    //    //}
    //    //public List<ArticleListModel> List()
    //    //{
    //    //    var listItems = _articleRepository.FindAll().OrderByDescending(t => t.Id);

    //    //    var model = new List<ArticleListModel>();

    //    //    foreach (var item in listItems)
    //    //    {
    //    //        ArticleListModel summary = new ArticleListModel
    //    //        {
    //    //            Id = item.Id,
    //    //            Published = item.Published,
    //    //            Name = item.Name,
    //    //            Tags = item.Tags,
    //    //            Picture = item.Picture
    //    //        };

    //    //        model.Add(summary);
    //    //    }

    //    //    return model;

    //    //}

    //    //public List<ArticleWebListModel> GetWebListModel(int count = 0)
    //    //{
    //    //    List<Article> listItems = null;

    //    //    if (count > 0)
    //    //        listItems = _articleRepository.FindAll(q => q.Published && q.PublishingDate <= DateTime.Now).OrderByDescending(t => t.Id).Take(count).ToList();
    //    //    else
    //    //        listItems = _articleRepository.FindAll(q => q.Published && q.PublishingDate <= DateTime.Now).OrderByDescending(t => t.Id).ToList();

    //    //    var model = new List<ArticleWebListModel>();


    //    //    foreach (var item in listItems)
    //    //    {
    //    //        ArticleWebListModel summary = new ArticleWebListModel
    //    //        {
    //    //            Id = item.Id,
    //    //            Name = item.Name,
    //    //            Picture = NewsPortalConstants.Folders.ArticleFullPath + item.Picture
    //    //        };

    //    //        if (item.LongContent.Length > 100)
    //    //            summary.SortContent = item.LongContent.Substring(0, Math.Min(item.LongContent.Length, 100));
    //    //        else
    //    //            summary.SortContent = item.LongContent;



    //    //        model.Add(summary);
    //    //    }

    //    //    return model;
    //    //}

    //    //public ArticleWebModel GetWebModel(int id)
    //    //{
    //    //    var item = _articleRepository.Find(q => q.Id == id && q.Published && q.PublishingDate <= DateTime.Now);

    //    //    if (item == null)
    //    //        throw new Exception("item not found!");

    //    //    var model = new ArticleWebModel
    //    //    {
    //    //        Id = item.Id,
    //    //        Name = item.Name,
    //    //        Tags = item.Tags,
    //    //        LongContent = item.LongContent,
    //    //        Picture = NewsPortalConstants.Folders.ArticleFullPath + item.Picture
    //    //    };

    //    //    return model;
    //    //}

    //    //public ArticlePagedListModel PagedList(PagingCommand command)
    //    //{
    //    //    var listItems = _articleRepository.FetchPaged(q => q.OrderByDescending(t => t.Id), command.PageIndex,
    //    //        command.PageSize);


    //    //    var model = new ArticlePagedListModel();

    //    //    foreach (var item in listItems)
    //    //    {
    //    //        ArticlePagedListModel.ArticleSummary summary = new ArticlePagedListModel.ArticleSummary
    //    //        {
    //    //            Id = item.Id,
    //    //            Name = item.Name,
    //    //            Tags = item.Tags,
    //    //            Picture = item.Picture
    //    //        };

    //    //        model.ListArticle.Add(summary);
    //    //    }

    //    //    return model;

    //    //}


    //    //public int AddOrUpdate(ArticleAddUpdateModel model)
    //    //{

    //    //    var item = _articleRepository.Find(q => q.Id == model.Id);

    //    //    if (item == null)
    //    //        item = new Article();

    //    //    item.Published = model.Published;
    //    //    item.PublishingDate = model.PublishingDate;
    //    //    item.Name = model.Name;
    //    //    item.Tags = model.Tags;

    //    //    // TODO : file Upload 
    //    //    item.Picture = model.Picture;

    //    //    item.LongContent = model.LongContent;

    //    //    if (item.Id > 0)
    //    //    {
    //    //        item.ModifiedDate = DateTime.Now;
    //    //        _articleRepository.Update(item);
    //    //    }
    //    //    else
    //    //    {
    //    //        _articleRepository.Add(item);
    //    //    }

    //    //    return item.Id;
    //    //}

    //    //public ArticleAddUpdateModel Get(int id)
    //    //{
    //    //    var item = _articleRepository.Find(q => q.Id == id);

    //    //    var model = new ArticleAddUpdateModel
    //    //    {
    //    //        Id = item.Id,
    //    //        Published = item.Published,
    //    //        PublishingDate = item.PublishingDate,
    //    //        Name = item.Name,
    //    //        Tags = item.Tags,
    //    //        Picture = item.Picture,
    //    //        LongContent = item.LongContent
    //    //    };

    //    //    return model;
    //    //}

    //    //public ArticleAddUpdateModel Edit()
    //    //{
    //    //    // TODO : Bu alan gereksiz.
    //    //    return new ArticleAddUpdateModel();
    //    //}

    //    //public void Delete(int id)
    //    //{
    //    //    var item = _articleRepository.Find(q => q.Id == id);

    //    //    if (item != null)
    //    //        _articleRepository.Delete(item);
    //    //}

    //    //public bool RemovePicture(int id)
    //    //{
    //    //    try
    //    //    {
    //    //        var item = _articleRepository.Get(id);

    //    //        item.Picture = String.Empty;

    //    //        _articleRepository.Update(item);
    //    //        return true;
    //    //    }
    //    //    catch
    //    //    {
    //    //        return false;
    //    //    }

    //    //}
    //}
}
