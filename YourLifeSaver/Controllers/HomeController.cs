﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourLifeSaver.Models;

namespace YourLifeSaver.Controllers
{
    public class HomeController : Controller
    {
        private webQuizModel db = new webQuizModel();

        public ActionResult Index()
        {
            return View();
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

        public ActionResult Information1()
        {
            return View();
        }

        public ActionResult Information2()
        {
            return View();
        }

        public ActionResult Information3()
        {
            return View();
        }

        public ActionResult Information4()
        {
            return View();
        }

        public ActionResult DataVirtualization()
        {
            return View();
        }
        public ActionResult RaiseAwarness()
        {
            return View();
        }

        public ActionResult FSupport1()
        {
            return View();
        }
        public ActionResult FSupport2()
        {
            return View();
        }
        public ActionResult FSupport3()
        {
            return View();
        }

    }
}