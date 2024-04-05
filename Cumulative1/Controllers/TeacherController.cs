using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cumulative1.Models;

namespace Cumulative1.Controllers
{
    public class TeacherController : Controller
    {   
        
        
        public ActionResult Index()
        {
            return View();
        }

        //GET teacher/list
       public ActionResult List(string SearchKey = null)
        {
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers(SearchKey);
            return View(Teachers);
        }

        //GET teacher/show/{id}
        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);

           return View(NewTeacher);
        }


        //POST: teacher/Delete/{id}
        public ActionResult Delete(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            controller.DeleteTeacher(id);
            return RedirectToAction("List");
        }

        //Shows an input webpage for a new teacher
        public ActionResult New()
        {
            return View();
        }


        //
        public ActionResult Create(string TeacherFname, string TeacherLname,
            string EmployeeNumber, string HireDate, string Salary)
        {
            Debug.WriteLine("Create Method Accessed");
            Debug.WriteLine("TeacherFname");
            Debug.WriteLine("TeacherLname");
            Debug.WriteLine("TeacherId");

            TeacherDataController controller = new TeacherDataController();
          //  controller.AddTeacher(NewTeacher);

            return RedirectToAction("List");
        }
    }
}