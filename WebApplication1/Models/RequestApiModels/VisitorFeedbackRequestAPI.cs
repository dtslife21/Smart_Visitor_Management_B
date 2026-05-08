using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class VisitorFeedbackRequestAPI : RequestAPI
    {
        public string VVF_Feedback_Id { get; set; }
        public string VV_Visitor_id { get; set; }
        public string VCP_Contact_person_id { get; set; }
        public string VVG_id { get; set; }
        public string VVF_Feedback_Description { get; set; }
        public string VVF_Status { get; set; }
        public string P_UID { get; set; }
    }
}