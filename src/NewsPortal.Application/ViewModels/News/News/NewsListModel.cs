 
namespace NewsPortal.Application.ViewModels.News
{
    public class NewsListModel
    {
        public int Id { get; set; }
        public bool Published { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public string Picture { get; set; }
    }
}
