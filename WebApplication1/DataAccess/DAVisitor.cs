using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.Database_Layer;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;
using biZTrack.Static;

namespace WebApplication1.DataAccess
{
    public class DAVisitor : IVisitor
    {
        private readonly string ProcedureName = "Visitor_Details";

        public Response AddVisitor(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "1";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Success!!";
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }

        public Response UpdateVisitor(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorModel> visitorList = new List<VisitorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorModel visitor = new VisitorModel
                        {
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VV_Contact_person_id = row["VV_Contact_person_id"].ToString(),
                            VV_Name = row["VV_Name"].ToString(),
                            VV_NIC_Passport_NO = row["VV_NIC_Passport_NO"].ToString(),
                            VV_Visiting_places = row["VV_Visiting_places"].ToString(),
                            VV_Visitor_Type = row["VV_Visitor_Type"].ToString(),
                            VV_Phone = row["VV_Phone"].ToString(),
                            VV_Email = row["VV_Email"].ToString(),
                            VV_Company = row["VV_Company"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Approval_Status = row["VV_Approval_Status"].ToString(),
                            VV_Status = row["VV_Status"].ToString()
                        };

                        visitorList.Add(visitor);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitorList;
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }

        public Response GetAllVisitors(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorModel> visitorList = new List<VisitorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorModel visitor = new VisitorModel
                        {
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VV_Contact_person_id = row["VV_Contact_person_id"].ToString(),
                            VV_Name = row["VV_Name"].ToString(),
                            VV_NIC_Passport_NO = row["VV_NIC_Passport_NO"].ToString(),
                            VV_Visiting_places = row["VV_Visiting_places"].ToString(),
                            VV_Visitor_Type = row["VV_Visitor_Type"].ToString(),
                            VV_Phone = row["VV_Phone"].ToString(),
                            VV_Email = row["VV_Email"].ToString(),
                            VV_Company = row["VV_Company"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Approval_Status = row["VV_Approval_Status"].ToString(),
                            VV_Status = row["VV_Status"].ToString()
                        };

                        visitorList.Add(visitor);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitorList;
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }

        public Response GetVisitorById(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorModel> visitorList = new List<VisitorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorModel visitor = new VisitorModel
                        {
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VV_Contact_person_id = row["VV_Contact_person_id"].ToString(),
                            VV_Name = row["VV_Name"].ToString(),
                            VV_NIC_Passport_NO = row["VV_NIC_Passport_NO"].ToString(),
                            VV_Visiting_places = row["VV_Visiting_places"].ToString(),
                            VV_Visitor_Type = row["VV_Visitor_Type"].ToString(),
                            VV_Phone = row["VV_Phone"].ToString(),
                            VV_Email = row["VV_Email"].ToString(),
                            VV_Company = row["VV_Company"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Approval_Status = row["VV_Approval_Status"].ToString(),
                            VV_Status = row["VV_Status"].ToString()
                        };

                        visitorList.Add(visitor);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitorList;
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }

        public Response ActivateVisitor(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "6";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Success!!";
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }

        public Response GetVisitorsByContactPerson(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "7";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorModel> visitorList = new List<VisitorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorModel visitor = new VisitorModel
                        {
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VV_Contact_person_id = row["VV_Contact_person_id"].ToString(),
                            VV_Name = row["VV_Name"].ToString(),
                            VV_NIC_Passport_NO = row["VV_NIC_Passport_NO"].ToString(),
                            VV_Visiting_places = row["VV_Visiting_places"].ToString(),
                            VV_Visitor_Type = row["VV_Visitor_Type"].ToString(),
                            VV_Phone = row["VV_Phone"].ToString(),
                            VV_Email = row["VV_Email"].ToString(),
                            VV_Company = row["VV_Company"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Approval_Status = row["VV_Approval_Status"].ToString(),
                            VV_Status = row["VV_Status"].ToString()
                        };

                        visitorList.Add(visitor);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitorList;
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }
        //UpdateK

        public Response GetVisitorJointDetails(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();
            // Assuming you want to call your new logic, change this to "7" 
            // or keep it dynamic based on the request
            requestAPI.ActionType = "8";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorJoinModel> visitorJoinList = new List<VisitorJoinModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorJoinModel visitor = new VisitorJoinModel
                        {
                            // Group Info Visitor_Id' 
                            Visitor_Group_Name = row["Visitor_Group_Name"].ToString(),
                            Visit_Group_NIC_Passport_Number = row["Visit_Group_NIC_Passport_Number"].ToString(),
                            RequestId = row["RequestId"].ToString(),
                            Visitor_gp_Id = row["Visitor_Id"].ToString(),

                            // Request Info
                            Visitor_Id = row["Visitor_Id"].ToString(),
                            Visitor_Places_to_Visit = row["Visitor_Places_to_Visit"].ToString(),

                            // Visitor Info  ✅ using SP aliases
                            Contact_Person_Id = row["Contact_Person_Id"].ToString(),
                            //Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            //Visitor_NIC_Passport_Number = row["Visitor_NIC_Passport_Number"].ToString(),
                            Visitor_NIC_Passport_Number = row["Visitor_NIC_Passport_Number"].ToString(),

                            // Contact Person Info
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Department = row["Contact_Person_Department"].ToString(),
                            Contact_Person_Phone_Number = row["Contact_Person_Phone_Number"].ToString(),

                            // Item Info  ✅ using SP aliases
                            Item_Id = row["Item_Id"].ToString(),
                            Item_Name = row["Item_Name"].ToString(),
                            Item_Quantity = row["Item_Quantity"].ToString(),
                            Item_Details = row["Item_Details"].ToString(),

                           // VIC_Designation = row["Item_Details"].ToString()

                        };

                        visitorJoinList.Add(visitor);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitorJoinList;
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }
        //Join new Action Type
        //public Response GetVisitorJointDetails(VisitorRequestAPI requestAPI)
        //{
        //    Response result = new Response();
        //    requestAPI.ActionType = "8";

        //    using (var dbConnect = new DBconnect())
        //    {
        //        ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
        //        if (res.ResultStatusCode == "1")
        //        {
        //            List<VisitorJoinModel> visitorJoinList = new List<VisitorJoinModel>();

        //            foreach (DataRow row in res.ResultDataTable.Rows)
        //            {
        //                VisitorJoinModel visitor = new VisitorJoinModel
        //                {
        //                    Visitor_Group_Name = row["Visitor_Group_Name"].ToString(),
        //                    Visit_Group_NIC_Passport_Number = row["Visit_Group_NIC_Passport_Number"].ToString(),
        //                    VVR_Request_id = row["VVR_Request_id"].ToString(),
        //                    VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
        //                    Visitor_Places_to_Visit = row["Visitor_Places_to_Visit"].ToString(),
        //                    VV_Contact_person_id = row["VV_Contact_person_id"].ToString(),
        //                    Visitor_Name = row["Visitor_Name"].ToString(),
        //                    Visitor_NIC_Passport_Number = row["Visitor_NIC_Passport_Number"].ToString(),
        //                    Contact_Person_Name = row["Contact_Person_Name"].ToString(),
        //                    Contact_Person_Department = row["Contact_Person_Department"].ToString(),
        //                    Contact_Person_Phone_Number = row["Contact_Person_Phone_Number"].ToString()
        //                };

        //                visitorJoinList.Add(visitor);
        //            }

        //            result.StatusCode = 200;
        //            result.ResultSet = visitorJoinList;
        //        }
        //        // End of Join new Action Type
        //        else
        //        {
        //            LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
        //            result.StatusCode = 500;
        //            result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
        //        }

        //        return result;
        //    }
        //}
        /*
        public Response AddJoinVisitor(VisitorRequestAPI requestAPI)
        {
            Response result = new Response();

            // NEW POST ACTION
            requestAPI.ActionType = "9";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);

                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Visitor Insert Success!!";
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage,
                        System.Reflection.MethodBase.GetCurrentMethod().Name);

                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage)
                        ? res.Result
                        : res.ExceptionMessage;
                }

                return result;
            }
        }*/
    }
}

