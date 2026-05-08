using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class VisitRequestRequestAPI : RequestAPI
    {
        public string VVR_Request_id { get; set; }
        public string VVR_Visitor_id { get; set; }
        public string VVR_Contact_person_id { get; set; }
        public string VVR_Visit_Date { get; set; }
        public string VVR_Places_to_Visit { get; set; }
        public string VVR_Purpose { get; set; }
        public string VVR_Status { get; set; }
        public string P_UID { get; set; }
    }
}

