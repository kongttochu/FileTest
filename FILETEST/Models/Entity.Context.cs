﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FILETEST.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FILETESTEntities : DbContext
    {
        public FILETESTEntities()
            : base("name=FILETESTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FILESAVETEST> FILESAVETEST { get; set; }
    
        public virtual ObjectResult<USP_GETFILENAMES_Result> USP_GETFILENAMES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GETFILENAMES_Result>("USP_GETFILENAMES");
        }
    
        public virtual int USP_SAVEFILEINFO(Nullable<int> sIZE, string eXTENSIOTN, string oRGNAME, string eNCODINGNAME, Nullable<System.DateTime> sAVEDATE)
        {
            var sIZEParameter = sIZE.HasValue ?
                new ObjectParameter("SIZE", sIZE) :
                new ObjectParameter("SIZE", typeof(int));
    
            var eXTENSIOTNParameter = eXTENSIOTN != null ?
                new ObjectParameter("EXTENSIOTN", eXTENSIOTN) :
                new ObjectParameter("EXTENSIOTN", typeof(string));
    
            var oRGNAMEParameter = oRGNAME != null ?
                new ObjectParameter("ORGNAME", oRGNAME) :
                new ObjectParameter("ORGNAME", typeof(string));
    
            var eNCODINGNAMEParameter = eNCODINGNAME != null ?
                new ObjectParameter("ENCODINGNAME", eNCODINGNAME) :
                new ObjectParameter("ENCODINGNAME", typeof(string));
    
            var sAVEDATEParameter = sAVEDATE.HasValue ?
                new ObjectParameter("SAVEDATE", sAVEDATE) :
                new ObjectParameter("SAVEDATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_SAVEFILEINFO", sIZEParameter, eXTENSIOTNParameter, oRGNAMEParameter, eNCODINGNAMEParameter, sAVEDATEParameter);
        }
    }
}
