
using NewsPortal.Application.ViewModels.NewsLike;
namespace NewsPortal.Application.Interfaces.Interfaces
{
    public interface INewsLikeService
    {
        bool CheckUserLikePostBefore(NewsLikeWebModel model);

        bool LikePostforUser(NewsLikeWebModel model);

        int GetTotalLikes();

        int GetTotalLikesByNewsId(int newsId);
    }
}
