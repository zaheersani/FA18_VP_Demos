﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppPart_I.Models;

namespace WebAppPart_I.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            ViewBag.Section = "BCS-6A";

            return View();
        }

        public ActionResult List()
        {
            Student sObj = new Student()
            {
                Name = "Talha",
                RegNo = "SP01-BCS-098"
            };

            return View("ListofStudents", sObj);
        }
	}
}