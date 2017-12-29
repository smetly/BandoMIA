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
            BandoView myview = new BandoView();

            TicketManager mgr = new TicketManager();

            myview.Bandos = mgr.getAbandondedProperties();

            //myview.Bandos = mgr.getCrackHouse();

            //myview.Bandos = mgr.getBeeInfest();

            //myview.Bandos = mgr.getCondemned();

            //myview.Bandos = mgr.getEmergency();

            //myview.Bandos = mgr.getMinimumHousing();



            return View(myview);
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