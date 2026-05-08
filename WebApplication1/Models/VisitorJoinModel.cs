public class VisitorJoinModel
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


/*
public string VIC_Item_Name { get; set; }
public string Item_Quantity { get; set; }
public string Item_Details { get; set; }
                        //RequestId = row["RequestId"].ToString(),
public string  VIC_Designation { get; set; }*/

/* From VMS_Visitor (Table c)
public string Visitor_Name { get; set; }
public string VV_Contact_person_id { get; set; }
public string Visitor_NIC_Passport_Number { get; set; }

// From VMS_Visit_Request_01 (Table b)
public string VVR_Request_id { get; set; }
public string VVR_Visitor_id { get; set; }
public string Visitor_Places_to_Visit { get; set; }

// From VMS_Visit_Group (Table a)
public string Visitor_Group_Name { get; set; } // Matches SQL Alias
public string Visit_Group_NIC_Passport_Number { get; set; } // Matches SQL Alias

// From VMS_Contact_Person (Table d)
public string Contact_Person_Name { get; set; }
public string Contact_Person_Department { get; set; }
public string Contact_Person_Phone_Number { get; set; }

// From VMS_Item_Carried (Table e)
public string VIC_Item_id { get; set; }
public string Item_Quantity { get; set; } // Matches SQL Alias: VIC_Quantity as Item_Quantity
public string Item_Details { get; set; }  // Matches SQL Alias: VIC_Designation as Item_Details
public string RequestId { get; set; }
public string VIC_Designation { get; set; }

}*/