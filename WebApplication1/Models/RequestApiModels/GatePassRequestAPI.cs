using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class GatePassRequestAPI : RequestAPI
    {
        public string VGP_Pass_id { get; set; }
        public string VGP_Visitor_id { get; set; }
        public string VGP_Request_id { get; set; }
        public string VGP_Issue_Date { get; set; }
        public string VGP_Status { get; set; }
        public string P_UID { get; set; }
    }
}
