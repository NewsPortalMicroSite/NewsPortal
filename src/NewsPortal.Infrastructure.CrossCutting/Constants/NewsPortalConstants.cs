 

namespace NewsPortal.Infrastructure.CrossCutting.Constants
{
    public class NewsPortalConstants
    {
        public static class Folders
        {
            public const string Uploads = "Uploads";
            public const string Article = "Article";
             
            public static readonly string ArticleFullPath = $"/{Uploads}/{Article}/";

        }
    }
}
