using FILETEST.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FILETEST.Controllers
{
    public class FileTestController : Controller
    {
        // GET: FileTest
        public ActionResult FileSave()
        {
            return View();
        }

        public ActionResult RegisterForm(HttpPostedFileBase file1)
        {
            HttpPostedFileBase file = file1;
            DataForFile dataFile = new DataForFile();
            FileSaveInfo info = dataFile.GetFileSaveInfo(file);
#if DEBUG
            string filePath = "C:\\FileTest";
            string savePath = Path.Combine(filePath, file.FileName);
            
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);
            file.SaveAs(savePath);
#endif
            DataForDB dataDB = new DataForDB();
            dataDB.SaveFileEntity(info);
            return View();
        }

        public JsonResult GetFileNameList()
        {
            DataForDB data = new DataForDB();
            string jsonData = JsonConvert.SerializeObject(data.GetFileNameListEntity());
            return Json(jsonData);
        }
    }
}