using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class VisitRequestModel
    {
        public string VVR_Request_id { get; set; }
        public string VVR_Visitor_id { get; set; }
        public string VVR_Contact_person_id { get; set; }
        public string VVR_Visit_Date { get; set; }
        public string VVR_Places_to_Visit { get; set; }
        public string VVR_Purpose { get; set; }
        public string VVR_Created_Date { get; set; }
        public string VVR_Created_By { get; set; }
        public string VVR_Update_Date { get; set; }
        public string VVR_Update_By { get; set; }
        public string VVR_Status { get; set; }
        public string Visitor_Name { get; set; }
        public string Visitor_Phone { get; set; }
        public string Visitor_Email { get; set; }
        public string Visitor_Company { get; set; }
        public string Contact_Person_Name { get; set; }
        public string Contact_Person_Email { get; set; }
        public string Contact_Person_Phone { get; set; }
        public string Contact_Person_Department { get; set; }
    }
}

