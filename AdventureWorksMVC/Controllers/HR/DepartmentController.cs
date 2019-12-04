using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.Controllers.HR
{
    public class DepartmentController : Controller
    {
        private AWContext dbContext;

        public DepartmentController()
        {
            dbContext = new AWContext();
        }

        // GET: Department
        public ActionResult Index()
        {
            var departments = dbContext.Department.Select(s => new Models.Department
            {
                DepartmentID = s.DepartmentID,
                Name = s.Name,
                GroupName = s.GroupName,
                ModifiedDate = s.ModifiedDate
            }).ToList();
            return View(departments);
        }

        public ActionResult Details(int? Id)
        {
            if(Id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            return View();
        }
    }
}