using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FILETEST.Models
{
    public class DataForFile
    {
        public FileSaveInfo GetFileSaveInfo(HttpPostedFileBase file)
        {
            string[] fileNames = file.FileName.Split('.');
            //Encoding
            byte[] basebyte = System.Text.Encoding.UTF8.GetBytes(file.FileName + DateTime.Now.ToString());
            string encodingFileName = Convert.ToBase64String(basebyte);

            DateTime dt = DateTime.Now;
            return new FileSaveInfo
            {
                FILE_SIZE = file.ContentLength
                ,FILE_EXTENTION = fileNames[1]
                ,FILE_ORGNAME = fileNames[0]
                ,FILE_ENCODINGNAME = encodingFileName
                ,FILE_SAVEDATE = dt
            };
        }
    }
}