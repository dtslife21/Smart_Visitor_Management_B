using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class AlertRequestAPI : RequestAPI
    {
        public string VA_Alert_id { get; set; }
        public string VA_Visit_id { get; set; }
        public string VA_Alert_Type { get; set; }
        public string VA_Message { get; set; }
        public string VA_Status { get; set; }
        

    }
}