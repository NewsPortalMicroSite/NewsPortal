 

namespace NewsPortal.Infrastructure.CrossCutting.Constants
{
    public class NewsPortalConstants
    {
        public static class Folders
        {
            public const string Uploads = "Uploads";
            public const string News = "News";
             
            public static readonly string NewsFullPath = $"/{Uploads}/{News}/";

        }
    }
}
