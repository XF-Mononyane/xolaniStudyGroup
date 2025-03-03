using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xolaniStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudent()
        {
            List<Models.StudentModel> student = new List<Models.StudentModel>();

            student.Add(new Models.StudentModel { StudentNumber = "u22566521", Name = "Xolani", Surname = "Mononyane", EmailAddress = "u22566521@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u23654148", Name = "Tebogo", Surname = "Phasha", EmailAddress = "u23654148@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u24987230", Name = "Eliocy", Surname = "Mugabe", EmailAddress = "u24987230@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u22558307", Name = "Liya", Surname = "Moleka", EmailAddress = "u22558307@tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u22738241", Name = "Dircus", Surname = "Engelbrecht", EmailAddress = "u22738241@tuks.co.za" });
            




            return View(student);
        }
    }
}