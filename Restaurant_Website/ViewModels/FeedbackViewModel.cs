namespace Restaurant_Website.ViewModels
{
    public class FeedbackViewModel
    {
        public int Id { get; set; }
        public string opinion { get; set; }
        public string CustomerImage { get; set; }
        public IFormFile CustomerImageFile {  get; set; }
        public bool IsActive { get; set; }
    }
}
