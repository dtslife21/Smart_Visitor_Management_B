using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class ContactPersonRequestAPI : RequestAPI
    {
        public string VCP_Contact_person_id { get; set; }
        public string VCP_Name { get; set; }
        public string VCP_Department { get; set; }
        public string VCP_Email { get; set; }
        public string VCP_Phone { get; set; }
        public string VCP_Status { get; set; }
        public string P_UID { get; set; }
    }
}

