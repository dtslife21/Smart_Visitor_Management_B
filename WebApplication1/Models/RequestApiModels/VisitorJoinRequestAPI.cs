using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models.RequestApiModels
{
    public class VisitorJoinRequestAPI


    {
        public string Visitor_Group_Name { get; set; }
        public string Visit_Group_NIC_Passport_Number { get; set; }
        public string RequestId { get; set; }
        public string Visitor_gp_Id { get; set; }
        public string Visitor_Id { get; set; }
        public string Visitor_Places_to_Visit { get; set; }
        public string Contact_Person_Id { get; set; }
        public string Visitor_Name { get; set; }
        public string Visitor_NIC_Passport_Number { get; set; }
        public string Contact_Person_Name { get; set; }
        public string Contact_Person_Department { get; set; }
        public string Contact_Person_Phone_Number { get; set; }
        public string Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Quantity { get; set; }
        public string Item_Details { get; set; }
    }
}
    
