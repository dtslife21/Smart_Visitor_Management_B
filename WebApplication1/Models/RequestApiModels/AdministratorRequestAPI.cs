using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class AdministratorRequestAPI : RequestAPI
    {
        public string VA_Admin_id { get; set; }
        public string VA_Name { get; set; }
        public string VA_Role { get; set; }
        public string VA_Email { get; set; }
        public string VA_Password { get; set; }
        public string VA_Status { get; set; }
        public string P_UID { get; set; }
    }
}

