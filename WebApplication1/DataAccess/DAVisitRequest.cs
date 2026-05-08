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
    public class DAVisitRequest : IVisitRequest
    {
        private readonly string ProcedureName = "VisitRequest_Details";

        public Response AddVisitRequest(VisitRequestRequestAPI requestAPI)
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

        public Response UpdateVisitRequest(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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

        public Response GetAllVisitRequests(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Email = row["Contact_Person_Email"].ToString(),
                            Contact_Person_Phone = row["Contact_Person_Phone"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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

        public Response GetVisitRequestById(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            Visitor_Company = row["Visitor_Company"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Email = row["Contact_Person_Email"].ToString(),
                            Contact_Person_Phone = row["Contact_Person_Phone"].ToString(),
                            Contact_Person_Department = row["Contact_Person_Department"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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

        public Response GetVisitRequestsByContactPerson(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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

        public Response GetVisitRequestsByVisitor(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "6";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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

        public Response GetVisitRequestsByDateRange(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "7";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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

        public Response ApproveVisitRequest(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "8";

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

        // public Response RejectVisitRequest(VisitRequestRequestAPI requestAPI)
        // {
        //     Response result = new Response();
        //     requestAPI.ActionType = "9";

        //     using (var dbConnect = new DBconnect())
        //     {
        //         ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
        //         if (res.ResultStatusCode == "1")
        //         {
        //             result.StatusCode = 200;
        //             result.Result = "Success!!";
        //         }
        //         else
        //         {
        //             LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
        //             result.StatusCode = 500;
        //             result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
        //         }

        //         return result;
        //     }
        // }

        // public Response CancelVisitRequest(VisitRequestRequestAPI requestAPI)
        // {
        //     Response result = new Response();
        //     requestAPI.ActionType = "10";

        //     using (var dbConnect = new DBconnect())
        //     {
        //         ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
        //         if (res.ResultStatusCode == "1")
        //         {
        //             result.StatusCode = 200;
        //             result.Result = "Success!!";
        //         }
        //         else
        //         {
        //             LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
        //             result.StatusCode = 500;
        //             result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
        //         }

        //         return result;
        //     }
        // }

        public Response GetPendingVisitRequests(VisitRequestRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "11";
            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitRequestModel> requestList = new List<VisitRequestModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitRequestModel req = new VisitRequestModel
                        {
                            VVR_Request_id = row["VVR_Request_id"].ToString(),
                            VVR_Visitor_id = row["VVR_Visitor_id"].ToString(),
                            VVR_Contact_person_id = row["VVR_Contact_person_id"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Created_Date = row["VVR_Created_Date"].ToString(),
                            VVR_Created_By = row["VVR_Created_By"].ToString(),
                            VVR_Update_Date = row["VVR_Update_Date"].ToString(),
                            VVR_Update_By = row["VVR_Update_By"].ToString(),
                            VVR_Status = row["VVR_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Email = row["Contact_Person_Email"].ToString()
                        };
                        requestList.Add(req);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = requestList;
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
    }
}

