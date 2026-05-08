using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AdministratorModel
    {
        public string VA_Admin_id { get; set; }
        public string VA_Name { get; set; }
        public string VA_Role { get; set; }
        public string VA_Email { get; set; }
        public string VA_Created_Date { get; set; }
        public string VA_Created_By { get; set; }
        public string VA_Update_Date { get; set; }
        public string VA_Update_By { get; set; }
        public string VA_Status { get; set; }
    }

    public class AdministratorLoginModel
    {
        public string VA_Admin_id { get; set; }
        public string VA_Name { get; set; }
        public string VA_Role { get; set; }
        public string VA_Email { get; set; }
       
        public string VA_Status { get; set; }
    }
}

