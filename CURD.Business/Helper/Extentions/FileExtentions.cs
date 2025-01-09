using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Helper.Extentions;
public static class FileExtentions
{
    public static string UploadFile(this IFormFile file, string rootPath, string folderName)
    {
        string fileName = file.FileName;
        if (fileName.Length > 64)
        {
            fileName = fileName.Substring(fileName.Length - 64);
        }
        fileName = Guid.NewGuid() + fileName;
        string path = Path.Combine(rootPath, folderName, fileName);

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            file.CopyTo(stream);
        }
        return fileName;
    }
    public static bool DeleteFile(string rootPath, string folderName, string fileName)
    {
        string path = Path.Combine(rootPath, folderName, fileName);

        if (!File.Exists(path))
        {
            return false;
        }
        File.Delete(path);
        return true;
    }


}
