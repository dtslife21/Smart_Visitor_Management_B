using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.RequestApiModels
{
    public class ItemJoinRequestAPI
    {
        //public string ActionType { get; set; }// new update
        public string Visitor_Name { get; set; }
        public string Contact_person_id { get; set; }
        public string Visitor_NIC_Passport_NO { get; set; }
        public string Request_id { get; set; }
        public string Visitor_id { get; set; }
        public string Group_Member_ID { get; set; }
        public string Group_Members { get; set; }
        public string Members_NIC_Passport_Number { get; set; }
        public string Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Quantity { get; set; }
        public string Item_Description { get; set; }
       // public string Group_Member_ID { get; set; }
        //public string VVG_id { get; set; }


    }
}