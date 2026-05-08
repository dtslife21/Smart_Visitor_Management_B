using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AlertModel
    {
        public string VA_Alert_id { get; set; }
        public string VA_Visit_id { get; set; }
        public string VA_Alert_Type { get; set; }
        public string VA_Message { get; set; }
        public string VA_Created_Date { get; set; }
        public string VA_Created_By { get; set; }
        public string VA_Update_Date { get; set; }
        public string VA_Update_By { get; set; }
        public string VA_Status { get; set; }

    }
}