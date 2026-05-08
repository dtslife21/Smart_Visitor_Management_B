using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class VisitGroupRequestAPI : RequestAPI
    {
        public string VVG_id { get; set; }
        public string VVG_Visitor_Name { get; set; }
        public string VVG_NIC_Passport_Number { get; set; }
        public string VVG_Designation { get; set; }
        // public string VVG_Created_Date { get; set; }
        public string VVG_Created_By { get; set; }
        // public string VVG_Update_Date { get; set; }
        public string VVG_Update_By { get; set; }
        public string VVG_Status { get; set; }
        public string VVR_Request_id { get; set; }
    }
}

