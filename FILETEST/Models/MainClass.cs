using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FILETEST.Models
{
    public class MainClass
    {
    }

    public class FileSaveInfo
    {
        public int IDX { get; set; }
        public int FILE_SIZE { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string FILE_ORGNAME { get; set; }
        public string FILE_ENCODINGNAME { get; set; }
        public DateTime FILE_SAVEDATE { get; set; }
        public DateTime REGDATE { get; set; }
        public string REGID { get; set; }
        public DateTime UPDDATE { get; set; }
        public string UPDID { get; set; }
        public bool ISUSE { get; set; }
    }
}