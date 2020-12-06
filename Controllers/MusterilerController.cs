﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;
namespace MvcStok.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDbStokEntities db = new MvcDbStokEntities();

        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERILER.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TBLMUSTERILER paramMusteri)
        {
            db.TBLMUSTERILER.Add(paramMusteri);
            db.SaveChanges();
            return View();
        }

    }
}