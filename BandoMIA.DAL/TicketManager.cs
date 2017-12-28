using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SODA.Utilities;
using SODA.Models;
using Newtonsoft.Json;
using BandoMIA.Models;


namespace BandoMIA.DAL
{
    public class TicketManager
    {
        public void getAbandondedProperties()
        {
            var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

            var dataset = client.GetResource<Ticket>("rbng-6mha.json");

            var allRows = dataset.GetRows();

            var soql = new SODA.SoqlQuery().Select("*")
                          .Where("issue_type > MINIMUM HOUSING OVA (OPEN/VACANT/ABANDONED)");


            var results = dataset.Query<Ticket>(soql);






        }
        public void getCrackHouseProperties()
        {
            var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

            var dataset = client.GetResource<Ticket>("rbng-6mha.json");

            var allRows = dataset.GetRows();

            var soql = new SODA.SoqlQuery().Select("*")
                          .Where("issue_type > MINIMUM HOUSING OVA (OPEN/VACANT/ABANDONED)");


            var results = dataset.Query<Ticket>(soql);
        }
    }
}
