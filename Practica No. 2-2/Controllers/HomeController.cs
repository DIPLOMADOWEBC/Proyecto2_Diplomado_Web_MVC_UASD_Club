﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_No._2_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fundadores()
        {
            return View();
        }

        public ActionResult Campeonatos()
        {
            return View();
        }
    }
}