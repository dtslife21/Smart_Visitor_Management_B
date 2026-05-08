using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AdministratorAuthKeyModel
    {
        public string VA_Admin_id { get; set; }
        public string VA_Role { get; set; }
        public string VA_Email { get; set; }
        public string AuthKey { get; set; }
    }
}

