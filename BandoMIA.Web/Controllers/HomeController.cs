using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BandoMIA.DAL;
using BandoMIA.Models;

namespace BandoMIA.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Ticket> output = null;

            TicketManager mgr = new TicketManager();

            output = mgr.getAbandondedProperties();

            

            return View(output.First<Ticket>());
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Bando MIA";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "smetly@gmail.com";

            return View();
        }
    }
}