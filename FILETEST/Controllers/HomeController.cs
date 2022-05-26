using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FILETEST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterForm(Member Member)
        {
            HttpPostedFileBase file = Member.file1;

            int filesize = file.ContentLength;
            string fileorgname = file.FileName;

            file.SaveAs("C:\\파일저장.jpg");


            ////Encoding
            //byte[] basebyte = System.Text.Encoding.UTF8.GetBytes(fileorgname + DateTime.Now.ToString());
            //string filename = Convert.ToBase64String(basebyte);

            ////Decoding
            //byte[] bytetest = Convert.FromBase64String(filename);
            //string fileresult = System.Text.Encoding.UTF8.GetString(bytetest);

            //--------------------------기본인증 예제
            // http://skymong9.egloos.com/v/1488073
            //try
            //{
            //    // 새 사용자 임시 로그온 하기
            //    IntPtr token = LogonUser("사용자 아이디", "사용자 패스워드", ".", LogonType.LOGON32_LOGON_NETWORK_CLEARTEXT, LogonProvider.LOGON32_PROVIDER_DEFAULT);
            //    WindowsIdentity identity = new WindowsIdentity(token);
            //    WindowsImpersonationContext ctx = identity.Impersonate();

            //    // 파일 업로드 컨트롤에 업로드할 파일이 선택 되었을 경우
            //    if (fileUploader1.HasFile)
            //    {
            //        // 네트워크 공유 폴더에 접근하여 파일을 저장
            //        fileUploader1.SaveAs(\\222.122.111.111\uploader\ +fileUploader1.FileName);
            //    }

            //    // 로그온 반환
            //    ctx.Undo();
            //}
            //catch (Exception ex)
            //{
            //}

            //strFtpSvr = ConfigurationSettings.AppSettings("FTP_SERVER")
            //if(strFtpSvr == "LOCAL")//내pc 이름으로 확인도 가능
            //{
            //    //서버와 할때
            //}
            //else
            //{
            //    //로컬로 테스트 할때
            //}

            return View();
        }


        public class Member
        {
            public string MemberID { get; set; }
            public string Password { get; set; }
            public string NickName { get; set; }
            public string Email { get; set; }
            public HttpPostedFileBase file1 { get; set; }
            public FileResult file2 { get; set; }

            public void Submit()
            {
                //멤버정보를 DB에 입력하는 등의 실제 작업을 처리한다
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}