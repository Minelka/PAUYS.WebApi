namespace PAUYS.WebApi.Services.Abstract
{
    public interface IFileUpload
    {
        string UploadFileName { get; }

        void Upload(IFormFile formFile);

        Task<string> UploadFileAsync(IFormFile formFile);

        string PictureFileName { get; }

    }
}
