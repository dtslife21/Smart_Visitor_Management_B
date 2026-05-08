using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.RequestApiModels
{
    public class VisitLogRequestAPI : RequestAPI
    {
        public string VVL_Visit_id { get; set; }
        public string VVL_Pass_id { get; set; }
        public string VVL_Accessed_Areas { get; set; }
        public string VVL_Check_Out_Time { get; set; }
        public string VVL_Expiry_Date { get; set; }
        public string VVL_Status { get; set; }
        public string P_UID { get; set; }
    }
}
