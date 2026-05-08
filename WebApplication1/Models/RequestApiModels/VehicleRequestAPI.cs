using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class VehicleRequestAPI : RequestAPI
    {
        public string VV_Vehicle_id { get; set; }
        public string VV_Vehicle_Number { get; set; }
        public string VV_Vehicle_Type { get; set; }
        public string VV_Status { get; set; }
       
        public string VVR_Request_id { get; set; }
        //public string P_UID { get; set; }
    }
}
