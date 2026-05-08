using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class VisitorFeedbackModel
    {
        public string VVF_Feedback_Id { get; set; }
        public string VV_Visitor_id { get; set; }
        public string VCP_Contact_person_id { get; set; }
        public string VVG_id { get; set; }
        public string VVF_Feedback_Description { get; set; }
        public string VVF_Created_Date { get; set; }
        public string VVF_Created_By { get; set; }
        public string VVF_Update_Date { get; set; }
        public string VVF_Update_By { get; set; }
        public string VVF_Status { get; set; }
    }
}