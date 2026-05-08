using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.RequestApiModels
{
    public class AdminItemListRequestAPI : RequestAPI
    {
        public string VAIL_Item_List_ID { get; set; }
        public string VA_Admin_id { get; set; }
        public string VAIL_Item_Name { get; set; }
       // public string VAIL_Created_Date { get; set; }
        //public string VAIL_Created_By { get; set; }
       // public string VAIL_Update_Date { get; set; }
       // public string VAIL_Update_By { get; set; }
        public string VAIL_Status { get; set; }
        public string P_UID { get; set; }
    }
}
