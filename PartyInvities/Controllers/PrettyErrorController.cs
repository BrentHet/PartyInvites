using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvities.Controllers
{
    public class PrettyErrorController : Controller
    {
        // GET: PrettyError
        public ActionResult Index()
        {
            return View("PrettyError");
        }
    }
}