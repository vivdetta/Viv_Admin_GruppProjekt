using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viv_Admin_GruppProjekt.Utils
{
    public static class DirectoriesHelper
    {
        public static string GetJsonReceptPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string solutionFolder = Path.Combine(basePath, @"..\..\..\Database");
            string jsonReceptFilePath = Path.Combine(solutionFolder, "master_recepts.json");

            return jsonReceptFilePath;
        }
    }
}
