using MvcMusicStore.Models;
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
        public string Index()
        {
            return "Hello, from StoreController.Index()";
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