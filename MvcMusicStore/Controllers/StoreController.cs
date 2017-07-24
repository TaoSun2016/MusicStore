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
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            //var gengres = new List<Genre> { new Genre {Name="Disco" },new Genre {Name="Jazz" }, new Genre {Name="Rock" } };
            var gengres = storeDB.Genres.ToList();
            return View(gengres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums").Single(g=>g.Name == genre);
            
            return View(genreModel);
        }

        // GET: Store/Details
        public ActionResult Details(int id)
        {
            Album album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}