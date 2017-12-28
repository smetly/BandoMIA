using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandoMIA.Models
{
    public class Ticket
    {
        public string case_owner { get; set; }
        public string case_owner_description { get; set; }
        public string city { get; set; }
        public string created_year_month { get; set; }
        public string goal_days { get; set; }
        public string issue_type { get; set; }
        public string latitude { get; set; }
        public Location location { get; set; }
        public string location_address { get; set; }
        public string location_city { get; set; }
        public string location_state { get; set; }
        public string location_zip { get; set; }
        public string longitude { get; set; }
        public string method_received { get; set; }
        public string neighborhood_district { get; set; }
        public string state { get; set; }
        public string street_address { get; set; }
        public DateTime ticket_created_date_time { get; set; }
        public string ticket_id { get; set; }
        public DateTime ticket_last_updated_date_time { get; set; }
        public string ticket_status { get; set; }
        public string x_coordinate { get; set; }
        public string y_coordinate { get; set; }
        public string zip_code { get; set; }
        public string actual_completed_days { get; set; }
        public DateTime? ticket_closed_date_time { get; set; }

    }
}
