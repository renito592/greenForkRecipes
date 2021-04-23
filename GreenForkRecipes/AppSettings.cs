using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes
{
    public class AppSettings
    {
        public FileUploadSettings FileUploadSettings { get; set; }
    }

    public class FileUploadSettings
    {
        public string UploadFolder { get; set; }
    }
}
