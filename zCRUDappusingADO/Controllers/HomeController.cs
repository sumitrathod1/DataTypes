using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zCRUDappusingADO.Models;

namespace zCRUDappusingADO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeDBcontain db =new EmployeeDBcontain();
            List<Employee> obj=db.getEmployees();
            return View(obj);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    EmployeeDBcontain ad = new EmployeeDBcontain();
                    bool check = ad.addEmploye(emp);
                    if (check == true)
                    {
                        TempData["InsertMessage"] = "Data has been inserted SuccessFully";
                        ModelState.Clear();
                        return RedirectToAction("Index");
                    }

                }
                return View();
            }
            catch
            {

                return View();
            }
        }

        public ActionResult edit(int id)
        {
            EmployeeDBcontain cont=new EmployeeDBcontain();
            var row = cont.getEmployees().Find(sa => sa.Id==id);
            return View(row);
        }

        [HttpPost]

        public ActionResult edit(int id,Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                EmployeeDBcontain ad = new EmployeeDBcontain();
                bool check = ad.updateEmployee(emp);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been UPDATED SuccessFully";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }

            }
            return View();
        }

        public ActionResult delete(int id)
        {
           EmployeeDBcontain cont=new EmployeeDBcontain();
            var row=cont.getEmployees().Find(sa => sa.Id==id);
            return View(row);
        }


        [HttpPost]
        public ActionResult delete(int id,Employee emp)
        {
            
                EmployeeDBcontain ad = new EmployeeDBcontain();
                bool check = ad.deleteEmploye(id);
                if (check == true)
                {
                    TempData["InsertMessage"] = "Data has been DElETED SuccessFully";
                    return RedirectToAction("Index");
                }
            return View();
        }
    }
}