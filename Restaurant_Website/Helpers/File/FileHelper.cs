namespace Restaurant_Website.Helpers.File
{
    public class FileHelper : IFileHelper
    {
        IWebHostEnvironment _webHostEnvironment;
        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string SaveImage(IFormFile file, string folderName, string OldImageName = null)
        {
            string FinalName;
            if (file != null)
            {
                List<string> allowedExtensions = new List<string>
                {
                    ".jpg", ".png", ".jpeg"
                };

                var rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", folderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }

                FileInfo fileInfo = new FileInfo(file.FileName);

                var newName = Guid.NewGuid().ToString() + fileInfo.Extension;

                if (allowedExtensions.Contains(fileInfo.Extension.ToLower()))
                {
                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    FinalName = $"/uploads/{folderName}/{newName}";
                }

                else
                {
                    FinalName = "Error";
                }
            }

            else
            {
                return OldImageName;
            }

            return FinalName;
        }

        public string SaveDoc(IFormFile file, string folderName, string OldImageName = null)
        {
            string FinalName;
            if (file != null)
            {
                List<string> allowedExtensions = new List<string>
                {
                    ".pdf", ".docx", ".doc"
                };

                var rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", folderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }

                FileInfo fileInfo = new FileInfo(file.FileName);

                var newName = Guid.NewGuid().ToString() + fileInfo.Extension;

                if (allowedExtensions.Contains(fileInfo.Extension.ToLower()))
                {
                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    FinalName = $"/uploads/{folderName}/{newName}";
                }

                else
                {
                    FinalName = "Error";
                }
            }

            else
            {
                return OldImageName;
            }

            return FinalName;
        }
    }
}
