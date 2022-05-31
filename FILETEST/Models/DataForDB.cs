using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FILETEST.Models
{
    public class DataForDB
    {
        public void SaveFile(FileSaveInfo info)
        {
            dbconn dbconn = new dbconn();
            string queryString =
                string.Format("EXEC USP_SAVEFILEINFO {0}, \'{1}\', \'{2}\', \'{3}\', \'{4}\'"
                , info.FILE_SIZE
                , info.FILE_EXTENTION
                , info.FILE_ORGNAME
                , info.FILE_ENCODINGNAME
                , info.FILE_SAVEDATE.ToString("yy-MM-dd"));
            var data = dbconn.ConnectDB(queryString);
        }
        public List<string> GetFileNameList()
        {
            List<string> list = new List<string>();
            dbconn dbconn = new dbconn();
            string queryString = string.Format("EXEC USP_GETFILENAMES");
            var data = dbconn.ConnectDB(queryString);

            DateTime dt = DateTime.Now;
            while (data.Read())
            {
                list.Add(
                    string.Format("{0}.{1}"
                    , data["FILE_ORGNAME"]
                    , data["FILE_EXTENTION"])
                    );
            }
            return list;
        }

        public void SaveFileEntity(FileSaveInfo info)
        {
            FILETESTEntities fs = new FILETESTEntities();
            fs.USP_SAVEFILEINFO(
                 info.FILE_SIZE
                , info.FILE_EXTENTION
                , info.FILE_ORGNAME
                , info.FILE_ENCODINGNAME
                , info.FILE_SAVEDATE
                );
        }

        public List<string> GetFileNameListEntity()
        {
            FILETESTEntities fs = new FILETESTEntities();
            var names = fs.USP_GETFILENAMES()
                .Select(n => string.Format("{0}.{1}", n.FILE_ORGNAME, n.FILE_EXTENTION))
                .ToList();
            return names;
        }
    }
}