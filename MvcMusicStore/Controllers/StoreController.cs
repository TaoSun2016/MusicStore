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
        public string Browse()
        {
            return "Hello, from StoreController.Browse()";
        }

        // GET: Store/Details
        public string Details()
        {
            return "Hello, from StoreController.Details()";
        }
    }
}