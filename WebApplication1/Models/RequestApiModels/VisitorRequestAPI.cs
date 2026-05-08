using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class VisitorRequestAPI : RequestAPI
    {

        
        public string VV_Visitor_id { get; set; }
        public string VV_Contact_person_id { get; set; }
        public string VV_Name { get; set; }
        public string VV_NIC_Passport_NO { get; set; }
        public string VV_Visiting_places { get; set; }
        public string VV_Visitor_Type { get; set; }
        public string VV_Phone { get; set; }
        public string VV_Email { get; set; }
        public string VV_Company { get; set; }
        public string VV_Status { get; set; }
        public string P_UID { get; set; }
        public string VV_Approval_Status { get; set; }
        public string RequestId { get; set; }  // ? ADD THIS

    }
}

