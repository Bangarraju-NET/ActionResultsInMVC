using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Text;
using ActionResultsInMVC.Models;
namespace ActionResultsInMVC.Controllers
{
    public class ResultsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region JsonResult
        public JsonResult GetEmployees()
        {
            Employee e1 = new Employee { Id = 101, Name = "Scott", Job = "CEO", Salary = 25000, Status = true };
            Employee e2 = new Employee { Id = 102, Name = "Smith", Job = "President", Salary = 22000, Status = true };
            Employee e3 = new Employee { Id = 103, Name = "Parker", Job = "Manager", Salary = 18000, Status = true };
            Employee e4 = new Employee { Id = 104, Name = "John", Job = "Salesman", Salary = 10000, Status = true };
            Employee e5 = new Employee { Id = 105, Name = "David", Job = "Clerk", Salary = 5000, Status = true };
            Employee e6 = new Employee { Id = 106, Name = "Maria", Job = "Analyst", Salary = 12000, Status = true };
            List<Employee> Emps = new List<Employee> { e1, e2, e3, e4, e5, e6 };
            return Json(Emps, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region FileResult
        public FileResult DownloadPdf()
        {
            return File("~/Downloads/Test.pdf", "application/pdf"); 
        }
        public FileResult DownloadWord()
        {
            return File("~/Downloads/Test.doc", "application/msword");
        }
        #endregion

        #region RedirectResult
        public RedirectResult OpenFaceBook()
        {
            return Redirect("https://facebook.com");
        }
        public RedirectResult OpenTwitter()
        {
            return Redirect("https://twitter.com");
        }
        #endregion

        #region ContentResult
        public ContentResult SendDate1()
        {
            string str = "Current Date: " + DateTime.Now.ToString();
            return Content(str);
        }
        public string SendDate2()
        {
            string str = "Current Date: " + DateTime.Now.ToString();
            return str;
        }
        public string SayHello1()
        {
            return "नमस्ते आप कैसे हैं?";
        }
        public ContentResult SayHello2()
        {
            return Content("नमस्ते आप कैसे हैं?", "text/plain", Encoding.Unicode);
        }
        #endregion

        #region JavaScriptResult
        public JavaScriptResult AlertUser()
        {
            return JavaScript("alert('Hello, how are you.');");
        }
        #endregion

        #region EmptyResult
        public EmptyResult ReturnEmpty1()
        {
            EmptyResult obj = new EmptyResult();
            return obj;
        }
        public void ReturnEmpty2()
        {
            string str = "Hello World";
            str = str.ToUpper();
        }
        #endregion
    }
}