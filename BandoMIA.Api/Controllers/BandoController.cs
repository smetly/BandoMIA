using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BandoMIA.Models;
using BandoMIA.DAL;

namespace BandoMIA.Api.Controllers
{
    public class BandoController : ApiController
    {
        
        [HttpGet]
        public IEnumerable<Ticket>GetAllBando()
        {
            IEnumerable<Ticket> output = null;

            TicketManager mgr = new TicketManager();

            output = mgr.getAbandondedProperties();

            return output;
        }
    }
}
