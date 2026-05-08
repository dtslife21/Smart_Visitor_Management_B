using biZTrack.Static;
using System;
using System.Collections.Generic;
using System.Data;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using WebApplication1;
using WebApplication1.Database_Layer;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.DataAccess
{
    public class DAAlert : IAlert
    {
        private readonly string ProcedureName = "Alert_Details";

        //1
        public Response AddAlert(AlertRequestAPI requestAPI)
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
            }

            return result;
        }
        //2
        public Response GetAllAlert(AlertRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AlertModel> AlertList = new List<AlertModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AlertModel alert = new AlertModel
                        {
                            VA_Alert_id = row["VA_Alert_id"].ToString(),
                            VA_Visit_id = row["VA_Visit_id"].ToString(),
                            VA_Alert_Type = row["VA_Alert_Type"].ToString(),
                            VA_Message = row["VA_Message"].ToString(),
                            VA_Created_Date = row["VA_Created_Date"].ToString(),
                            VA_Created_By = row["VA_Created_By"].ToString(),
                            //VA_Update_Date = row["VA_Update_By"].ToString(),//incorrect
                           // VA_Update_By = row["VB_Description"].ToString(),//incorrect
                            VA_Status = row["VA_Status"].ToString(),

                        };

                        AlertList.Add(alert);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = AlertList;
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
        //3
        public Response GetByIdAlert(AlertRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AlertModel> AlertList = new List<AlertModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AlertModel alert = new AlertModel
                        {
                            VA_Alert_id = row["VA_Alert_id"].ToString(),
                            VA_Visit_id = row["VA_Visit_id"].ToString(),
                            VA_Alert_Type = row["VA_Alert_Type"].ToString(),
                            VA_Message = row["VA_Message"].ToString(),
                            VA_Created_Date = row["VA_Created_Date"].ToString(),
                            VA_Created_By = row["VA_Created_By"].ToString(),
                            VA_Update_Date = row["VA_Update_Date"].ToString(),
                            VA_Update_By = row["VA_Update_By"].ToString(),
                            VA_Status = row["VA_Status"].ToString(),

                        };

                        AlertList.Add(alert);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = AlertList;
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

        //4
        public Response UpdateAlert(AlertRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Alert Updated Successfully!!";
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
        //5 UPDATE Status

        public Response ActivateAlert(AlertRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Alert Status Updated Successfully!!";
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