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
    public class DAGatePass : IGatePass
    {
        private readonly string ProcedureName = "GatePass_Details";

        public Response AddGatePass(GatePassRequestAPI requestAPI)
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

        public Response UpdateGatePass(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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

        public Response GetAllGatePasses(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            Visitor_Company = row["Visitor_Company"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Phone = row["Contact_Person_Phone"].ToString(),
                            Contact_Person_Email = row["Contact_Person_Email"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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

        public Response GetGatePassById(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            VV_NIC_Passport_NO = row["VV_NIC_Passport_NO"].ToString(),
                            Visitor_Company = row["Visitor_Company"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Phone = row["Contact_Person_Phone"].ToString(),
                            Contact_Person_Email = row["Contact_Person_Email"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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

        public Response GetGatePassesByVisitorId(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString(),
                            Contact_Person_Name = row["Contact_Person_Name"].ToString(),
                            Contact_Person_Phone = row["Contact_Person_Phone"].ToString(),
                            Contact_Person_Email = row["Contact_Person_Email"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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

        public Response GetGatePassByRequestId(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "6";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString(),
                            VVR_Places_to_Visit = row["VVR_Places_to_Visit"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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

        public Response UpdateGatePassStatus(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "7";

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

        public Response GetActiveGatePasses(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "8";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString(),
                            Visitor_Email = row["Visitor_Email"].ToString(),
                            VVR_Visit_Date = row["VVR_Visit_Date"].ToString(),
                            VVR_Purpose = row["VVR_Purpose"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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

        public Response GetGatePassesByDateRange(GatePassRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "9";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<GatePassModel> gatePassList = new List<GatePassModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        GatePassModel gatePass = new GatePassModel
                        {
                            VGP_Pass_id = row["VGP_Pass_id"].ToString(),
                            VGP_Visitor_id = row["VGP_Visitor_id"].ToString(),
                            VGP_Request_id = row["VGP_Request_id"].ToString(),
                            VGP_Issue_Date = row["VGP_Issue_Date"].ToString(),
                            VGP_Created_Date = row["VGP_Created_Date"].ToString(),
                            VGP_Created_By = row["VGP_Created_By"].ToString(),
                            VGP_Update_Date = row["VGP_Update_Date"].ToString(),
                            VGP_Update_By = row["VGP_Update_By"].ToString(),
                            VGP_Status = row["VGP_Status"].ToString(),
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Visitor_Phone = row["Visitor_Phone"].ToString()
                        };

                        gatePassList.Add(gatePass);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = gatePassList;
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
