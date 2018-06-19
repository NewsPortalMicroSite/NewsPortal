
using System;

namespace NewsPortal.Application.ViewModels.News
{
    public class NewsAddUpdateModel
    {
        public int Id { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishingDate { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }

      
        public string LongContent { get; set; }

        public string Tags { get; set; }
    }
}
