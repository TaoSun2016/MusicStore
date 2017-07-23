﻿using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var gengres = new List<Genre> { new Genre {Name="Disco" },new Genre {Name="Jazz" }, new Genre {Name="Rock" } };
            return View(gengres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name=genre};
            
            return View(genreModel);
        }

        // GET: Store/Details
        public ActionResult Details(int id)
        {
            Album album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}