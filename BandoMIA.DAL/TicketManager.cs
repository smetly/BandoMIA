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
        public IEnumerable<Ticket> getAbandondedProperties()
        {
            try
            {
                var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

                var dataset = client.GetResource<Ticket>("rbng-6mha");              

                var allRows = dataset.GetRows(35);

                
                var soql = new SODA.SoqlQuery().Select("case_owner", "case_owner_description", "city", "created_year_month", "goal_days",
                                                        "issue_type", "latitude", "location", "location_address", "location_city", "location_state", "location_zip", "longitude", "method_received",
                                                        "neighborhood_district", "state", "street_address", "ticket_created_date_time", "ticket_id", "ticket_last_updated_date_time",
                                                        "ticket_status", "x_coordinate", "y_coordinate", "zip_code", "actual_completed_days", "ticket_closed_date_time")
                              .Where("issue_type = 'MINIMUM HOUSING OVA (OPEN/VACANT/ABANDONED)'");

                //var results = dataset.Query(soql);

                var results = dataset.Query<Ticket>(soql);

                var result2 = results.Where(x => x.zip_code == "33179");

                //var results = allRows.ToList<Ticket>();

                return result2;
            }
            catch (Exception err)
            {
                string message = err.Message;
                throw;
            }






        }

        public IEnumerable<Ticket>getCrackHouse()
        {
            try
            {
                var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

                var dataset = client.GetResource<Ticket>("rbng-6mha");

                var allRows = dataset.GetRows(35);


                var soql = new SODA.SoqlQuery().Select("case_owner", "case_owner_description", "city", "created_year_month", "goal_days",
                                                        "issue_type", "latitude", "location", "location_address", "location_city", "location_state", "location_zip", "longitude", "method_received",
                                                        "neighborhood_district", "state", "street_address", "ticket_created_date_time", "ticket_id", "ticket_last_updated_date_time",
                                                        "ticket_status", "x_coordinate", "y_coordinate", "zip_code", "actual_completed_days", "ticket_closed_date_time")
                              .Where("issue_type = 'MINIMUM HOUSING CRACK HOUSE'");

                //var results = dataset.Query(soql);

                var results = dataset.Query<Ticket>(soql);

                //var result2 = results.Where(x => x.zip_code == "33179");

                //var results = allRows.ToList<Ticket>();

                return results;
            }
            catch (Exception err)
            {
                string message = err.Message;
                throw;
            }
        }



        public IEnumerable<Ticket> getCondemned()
        {
            try
            {
                var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

                var dataset = client.GetResource<Ticket>("rbng-6mha");

                var allRows = dataset.GetRows(35);


                var soql = new SODA.SoqlQuery().Select("case_owner", "case_owner_description", "city", "created_year_month", "goal_days",
                                                        "issue_type", "latitude", "location", "location_address", "location_city", "location_state", "location_zip", "longitude", "method_received",
                                                        "neighborhood_district", "state", "street_address", "ticket_created_date_time", "ticket_id", "ticket_last_updated_date_time",
                                                        "ticket_status", "x_coordinate", "y_coordinate", "zip_code", "actual_completed_days", "ticket_closed_date_time")
                              .Where("issue_type = 'MINIMUM HOUSING CONDEMNATION'");

                //var results = dataset.Query(soql);

                var results = dataset.Query<Ticket>(soql);

                //var result2 = results.Where(x => x.zip_code == "33179");

                //var results = allRows.ToList<Ticket>();

                return results;
            }
            catch (Exception err)
            {
                string message = err.Message;
                throw;
            }
        }


        public IEnumerable<Ticket> getBeeInfest()
        {
            try
            {
                var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

                var dataset = client.GetResource<Ticket>("rbng-6mha");

                var allRows = dataset.GetRows(35);


                var soql = new SODA.SoqlQuery().Select("case_owner", "case_owner_description", "city", "created_year_month", "goal_days",
                                                        "issue_type", "latitude", "location", "location_address", "location_city", "location_state", "location_zip", "longitude", "method_received",
                                                        "neighborhood_district", "state", "street_address", "ticket_created_date_time", "ticket_id", "ticket_last_updated_date_time",
                                                        "ticket_status", "x_coordinate", "y_coordinate", "zip_code", "actual_completed_days", "ticket_closed_date_time")
                              .Where("issue_type = 'MINIMUM HOUSING BEE INFESTATION'");

                //var results = dataset.Query(soql);

                var results = dataset.Query<Ticket>(soql);

                //var result2 = results.Where(x => x.zip_code == "33179");

                //var results = allRows.ToList<Ticket>();

                return results;
            }
            catch (Exception err)
            {
                string message = err.Message;
                throw;
            }
        }


        public IEnumerable<Ticket> getMinimumHousing()
        {
            try
            {
                var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

                var dataset = client.GetResource<Ticket>("rbng-6mha");

                var allRows = dataset.GetRows(35);


                var soql = new SODA.SoqlQuery().Select("case_owner", "case_owner_description", "city", "created_year_month", "goal_days",
                                                        "issue_type", "latitude", "location", "location_address", "location_city", "location_state", "location_zip", "longitude", "method_received",
                                                        "neighborhood_district", "state", "street_address", "ticket_created_date_time", "ticket_id", "ticket_last_updated_date_time",
                                                        "ticket_status", "x_coordinate", "y_coordinate", "zip_code", "actual_completed_days", "ticket_closed_date_time")
                              .Where("issue_type = 'MINIMUM HOUSING MAINTENANCE'");

                //var results = dataset.Query(soql);

                var results = dataset.Query<Ticket>(soql);

                //var result2 = results.Where(x => x.zip_code == "33179");

                //var results = allRows.ToList<Ticket>();

                return results;
            }
            catch (Exception err)
            {
                string message = err.Message;
                throw;
            }
        }


        public IEnumerable<Ticket> getEmergency()
        {
            try
            {
                var client = new SODA.SodaClient("opendata.miamidade.gov", "YHSAnuynbCuoP7oEQB2yLXy3B");

                var dataset = client.GetResource<Ticket>("rbng-6mha");

                var allRows = dataset.GetRows(35);


                var soql = new SODA.SoqlQuery().Select("case_owner", "case_owner_description", "city", "created_year_month", "goal_days",
                                                        "issue_type", "latitude", "location", "location_address", "location_city", "location_state", "location_zip", "longitude", "method_received",
                                                        "neighborhood_district", "state", "street_address", "ticket_created_date_time", "ticket_id", "ticket_last_updated_date_time",
                                                        "ticket_status", "x_coordinate", "y_coordinate", "zip_code", "actual_completed_days", "ticket_closed_date_time")
                              .Where("issue_type = 'MINIMUM HOUSING EMERGENCY'");

                //var results = dataset.Query(soql);

                var results = dataset.Query<Ticket>(soql);

                //var result2 = results.Where(x => x.zip_code == "33179");

                //var results = allRows.ToList<Ticket>();

                return results;
            }
            catch (Exception err)
            {
                string message = err.Message;
                throw;
            }
        }

    }
}
