namespace Restaurant_Website.Helpers.File
{
    public interface IFileHelper
    {
        string SaveImage(IFormFile file, string folderName, string OldImageName = null);

        string SaveDoc(IFormFile file, string folderName, string OldImageName = null);

    }
}
