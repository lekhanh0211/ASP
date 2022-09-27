﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject_Sem3.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
       
        public ActionResult Index()
        {
            if (Session["Admin"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }
    }
}
