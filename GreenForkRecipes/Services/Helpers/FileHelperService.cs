using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services.Helpers
{
    public class FileHelperService
    {
        public string BuildFilePath(string directory,string filePath)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            return Path.Combine(directory, filePath);
        }

        public void CreateFile(IFormFile file,string filePath)
        {
            using (FileStream stream = new FileStream(filePath,FileMode.Create))
            {
                file.CopyTo(stream);
            }
        }
    }
}
