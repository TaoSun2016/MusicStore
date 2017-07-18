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
        public string Browse(string genre)
        {
            string message =  HttpUtility.HtmlEncode("Store.Browse, Genre =" + genre);
            return message;
        }

        // GET: Store/Details
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode("ID = "+id);
            return message;
        }
    }
}