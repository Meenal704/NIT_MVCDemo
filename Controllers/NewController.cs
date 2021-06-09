using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NIT_First_Demo.Models;

namespace NIT_First_Demo.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        //Attribute based routing
        [Route("Hotel/Biryani")]
        [Route("Hotel/Veg")]
        public string Index()
        {
            return "Hello World";
        }

        public int Index2()
        {
            return 1234;
        }

        public string Index3(int? id)
        {
            return "My Employee Id is:-" + id;
        }

        public ActionResult GetMeView()
        {

            return View("Tesla");
        }

        public ActionResult GetMeView2()
        {

            return View("~/Views/Test/Index.cshtml");
        }
        public ActionResult GetMeView3()
        {
            ViewBag.info = "Wipro";

            return View();
        }
        public ActionResult GetMeView4()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Meenal";
            emp.EmpSalary = 80000;

            ViewBag.info = emp;

            return View();
        }

        public ActionResult GetMeView5()
        {
            List<EmployeeModel> listEmpinfo = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Meenal";
            emp.EmpSalary = 80000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Ritu";
            emp1.EmpSalary = 70000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Aarti";
            emp2.EmpSalary = 85000;

            listEmpinfo.Add(emp);
            listEmpinfo.Add(emp1);
            listEmpinfo.Add(emp2);

            ViewBag.info = listEmpinfo;

            return View();
        }
        public ActionResult GetMeView6()
        {

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Meenal";
            emp.EmpSalary = 80000;

            return View(emp);
        }

        public ActionResult GetMeView7()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Meenal";
            emp.EmpSalary = 80000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Ritu";
            emp1.EmpSalary = 70000;

            listObj.Add(emp);
            listObj.Add(emp1);

            return View(listObj);
        }

        public ActionResult GetMeView8()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Meenal";
            emp.EmpSalary = 80000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Ritu";
            emp1.EmpSalary = 70000;

            listObj.Add(emp);
            listObj.Add(emp1);

            Department dept = new Department();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            EmpDept obj = new EmpDept();
            obj.emp = listObj;
            obj.Dept = dept;

            return View(obj);
        }
    }
}