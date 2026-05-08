using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class ItemCarriedRequestAPI : RequestAPI
    {
        public string VIC_Item_id { get; set; }
        public string VIC_Item_Name { get; set; }
        public string VIC_Quantity { get; set; }
        public string VIC_Designation { get; set; }
        public string VIC_Status { get; set; }
        //public string VIC_Created_By { get; set; }
        //public string VIC_Update_By { get; set; }
        public string VVR_Request_id { get; set; }
        public string Group_Member_ID { get; set; }
        public string VVG_id { get; set; }

        // public string P_UID { get; set; }
    }
}
