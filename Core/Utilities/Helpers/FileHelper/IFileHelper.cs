using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);//root : kaydedilecek dizin /file yüklenen dosya
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
    }
}
