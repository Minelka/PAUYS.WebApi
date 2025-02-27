using PAUYS.WebApi.Services.Abstract;

namespace PAUYS.WebApi.Services.Concrete
{
    public class FileUpload : IFileUpload
    {
        private readonly string _uploadPath;
        private string _uploadFileName = string.Empty;

        public FileUpload()
        {
            _uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "admin", "uploads");
            if (!Directory.Exists(_uploadPath))
                Directory.CreateDirectory(_uploadPath);
        }

        public string UploadFileName => _uploadFileName;

        public string PictureFileName => _uploadFileName; // Arabirimde istenen özellik

        public void Upload(IFormFile formFile)
        {
            var fileName = GenerateFileName(formFile.FileName);
            var filePath = Path.Combine(_uploadPath, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                formFile.CopyTo(fileStream);
                _uploadFileName = filePath.Split("wwwroot")[1].Replace("\\", "/");
            }
        }

        public async Task<string> UploadFileAsync(IFormFile formFile)
        {
            var fileName = GenerateFileName(formFile.FileName);
            var filePath = Path.Combine(_uploadPath, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await formFile.CopyToAsync(fileStream);
                _uploadFileName = filePath.Split("wwwroot")[1].Replace("\\", "/");
            }

            return _uploadFileName;
        }

        private string GenerateFileName(string originalFileName)
        {
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);
            var fileExtension = Path.GetExtension(originalFileName);
            return $"{fileNameWithoutExtension}_{Guid.NewGuid()}_{DateTime.Now:yyyyMMddHHmmss}{fileExtension}";
        }
    }
}
