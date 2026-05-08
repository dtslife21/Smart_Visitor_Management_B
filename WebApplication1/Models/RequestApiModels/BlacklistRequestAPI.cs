using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class BlacklistRequestAPI : RequestAPI
    {
        public string VB_id { get; set; }
        public string VB_Admin_id { get; set; }
        public string VB_Visitor_id { get; set; }
        public string VB_Name { get; set; }
        public string VB_Role { get; set; }
        public string VB_Email { get; set; }
        public string VB_Alert_Type { get; set; }
        public string VB_Description { get; set; }
        public string VB_Status { get; set; }
      //  public string P_UID { get; internal set; }
    }
}