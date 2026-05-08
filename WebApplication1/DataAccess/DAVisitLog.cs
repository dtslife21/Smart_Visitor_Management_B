using biZTrack.Static;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.Database_Layer;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.DataAccess
{
    public class DAVisitLog : IVisitLog
    {
        private readonly string ProcedureName = "VisitLog_Details";

        public Response AddVisitLog(VisitLogRequestAPI requestAPI)
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

        public Response UpdateVisitLog(VisitLogRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

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

        public Response GetAllVisitLogs(VisitLogRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitLogModel> visitLogList = new List<VisitLogModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitLogModel visitLog = new VisitLogModel
                        {
                            VVL_Visit_id = row["VVL_Visit_id"].ToString(),
                            VVL_Pass_id = row["VVL_Pass_id"].ToString(),
                            VVL_Check_in_Time = row["VVL_Check_in_Time"].ToString(),
                            VVL_Check_Out_Time = row["VVL_Check_Out_Time"].ToString(),
                            VVL_Accessed_Areas = row["VVL_Accessed_Areas"].ToString(),
                            VVL_Expiry_Date = row["VVL_Expiry_Date"].ToString(),
                            VVL_Created_Date = row["VVL_Created_Date"].ToString(),
                            VVL_Created_By = row["VVL_Created_By"].ToString(),
                            VVL_Update_Date = row["VVL_Update_Date"].ToString(),
                            VVL_Update_By = row["VVL_Update_By"].ToString(),
                            VVL_Status = row["VVL_Status"].ToString()
                        };

                        visitLogList.Add(visitLog);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitLogList;
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

        public Response GetVisitLogById(VisitLogRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitLogModel> visitLogList = new List<VisitLogModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitLogModel visitLog = new VisitLogModel
                        {
                            VVL_Visit_id = row["VVL_Visit_id"].ToString(),
                            VVL_Pass_id = row["VVL_Pass_id"].ToString(),
                            VVL_Check_in_Time = row["VVL_Check_in_Time"].ToString(),
                            VVL_Check_Out_Time = row["VVL_Check_Out_Time"].ToString(),
                            VVL_Accessed_Areas = row["VVL_Accessed_Areas"].ToString(),
                            VVL_Expiry_Date = row["VVL_Expiry_Date"].ToString(),
                            VVL_Created_Date = row["VVL_Created_Date"].ToString(),
                            VVL_Created_By = row["VVL_Created_By"].ToString(),
                            VVL_Update_Date = row["VVL_Update_Date"].ToString(),
                            VVL_Update_By = row["VVL_Update_By"].ToString(),
                            VVL_Status = row["VVL_Status"].ToString()
                        };

                        visitLogList.Add(visitLog);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = visitLogList;
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

        public Response DeleteVisitLog(VisitLogRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

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
    }
}
