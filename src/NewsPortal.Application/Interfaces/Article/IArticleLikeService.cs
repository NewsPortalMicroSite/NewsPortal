
using NewsPortal.Application.ViewModels.NewsLike;

namespace NewsPortal.Application.Interfaces.Article
{
    public interface IArticleLikeService
    {
        bool CheckUserLikePostBefore(ArticleLikeWebModel model);

        bool LikePostforUser(ArticleLikeWebModel model);

        int GetTotalLikes();

        int GetTotalLikesByArticleId(int articleId);
    }
}
