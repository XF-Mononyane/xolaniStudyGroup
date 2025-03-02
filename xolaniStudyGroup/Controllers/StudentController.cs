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

            student.Add(new Models.StudentModel { StudentNumber = "u22566521", Name = "Xolani", Surname = "Mononyane", EmailAddress = "u22566521@Tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u23654148", Name = "Tebogo", Surname = "Phasha", EmailAddress = "u23654148@Tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u24987230", Name = "Eliocy", Surname = "Mogabe", EmailAddress = "u24987230@Tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u22558307", Name = "Liyabona", Surname = "Moleka", EmailAddress = "u22558307@Tuks.co.za" });
            student.Add(new Models.StudentModel { StudentNumber = "u22738241", Name = "Dirco", Surname = "Engelbrecht", EmailAddress = "u22738241@Tuks.co.za" });
            




            return View(student);
        }
    }
}