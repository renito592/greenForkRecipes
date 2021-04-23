using GreenForkRecipes.Services.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GreenForkRecipes.Services
{
    public class ImageUploadService
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly AppSettings appSettings;
        private readonly FileHelperService fileHelperService;

        public ImageUploadService(IWebHostEnvironment webHostEnvironment, AppSettings appSettings, FileHelperService fileHelperService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.appSettings = appSettings;
            this.fileHelperService = fileHelperService;
        }

        public string UploadPicture(IFormFile pictureFile)
        {
            string fileEx = pictureFile.FileName.Substring(pictureFile.FileName.LastIndexOf('.')).ToLower();

            string filePath = $"{Guid.NewGuid()}{fileEx}";
            string folderPath = Path.Combine(webHostEnvironment.WebRootPath, appSettings.FileUploadSettings.UploadFolder);
            string fullFilePath = fileHelperService.BuildFilePath(folderPath, filePath);
            fileHelperService.CreateFile(pictureFile, fullFilePath);
            return filePath;

        }
    }
}
