using biZTrack.Static;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;
using WebApplication1.Database_Layer;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.DataAccess
{
    public class DABlacklist : IBlacklist
    {
        private readonly string ProcedureName = "Blacklist_Details";

        //1
        public Response AddBlacklist(BlacklistRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "1";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "200")
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
        public Response GetAllBlacklist(BlacklistRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<BlacklistModel> BlacklistList = new List<BlacklistModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        BlacklistModel blacklist = new BlacklistModel
                        {
                            VB_id = row["VB_id"].ToString(),
                            VB_Admin_id = row["VB_Admin_id"].ToString(),
                            VB_Visitor_id = row["VB_Visitor_id"].ToString(),
                            VB_Name = row["VB_Name"].ToString(),
                            VB_Role = row["VB_Role"].ToString(),
                            VB_Email = row["VB_Email"].ToString(),
                            VB_Alert_Type = row["VB_Alert_Type"].ToString(),
                            VB_Description = row["VB_Description"].ToString(),
                            VB_Created_Date = row["VB_Created_Date"].ToString(),
                            VB_Created_By = row["VB_Created_By"].ToString(),
                            VB_Update_Date = row["VB_Update_Date"].ToString(),
                            VB_Update_By = row["VB_Update_By"].ToString(),
                            VB_Status = row["VB_Status"].ToString(),
                        };

                        BlacklistList.Add(blacklist);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = BlacklistList;
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
        public Response GetByIdBlacklist(BlacklistRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<BlacklistModel> BlacklistList = new List<BlacklistModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        BlacklistModel blacklist = new BlacklistModel
                        {
                            VB_id = row["VB_id"].ToString(),
                            VB_Admin_id = row["VB_Admin_id"].ToString(),
                            VB_Visitor_id = row["VB_Visitor_id"].ToString(),
                            VB_Name = row["VB_Name"].ToString(),
                            VB_Role = row["VB_Role"].ToString(),
                            VB_Email = row["VB_Email"].ToString(),
                            VB_Alert_Type = row["VB_Alert_Type"].ToString(),
                            VB_Description = row["VB_Description"].ToString(),
                            VB_Created_Date = row["VB_Created_Date"].ToString(),
                            VB_Created_By = row["VB_Created_By"].ToString(),
                            VB_Update_Date = row["VB_Update_Date"].ToString(),
                            VB_Update_By = row["VB_Update_By"].ToString(),
                            VB_Status = row["VB_Status"].ToString()
                        };

                        BlacklistList.Add(blacklist);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = BlacklistList;
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
        public Response UpdateBlacklist(BlacklistRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "200")
                {
                    List<BlacklistModel> BlacklistList = new List<BlacklistModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        BlacklistModel blacklist = new BlacklistModel
                        {
                            VB_id = row["VB_id"].ToString(),
                            VB_Admin_id = row["VB_Admin_id"].ToString(),
                            VB_Visitor_id = row["VB_Visitor_id"].ToString(),
                            VB_Name = row["VB_Name"].ToString(),
                            VB_Role = row["VB_Role"].ToString(),
                            VB_Email = row["VB_Email"].ToString(),
                            VB_Alert_Type = row["VB_Alert_Type"].ToString(),
                            VB_Description = row["VB_Description"].ToString(),
                            VB_Created_Date = row["VB_Created_Date"].ToString(),
                            VB_Created_By = row["VB_Created_By"].ToString(),
                            VB_Update_Date = row["VB_Update_Date"].ToString(),
                            VB_Update_By = row["VB_Update_By"].ToString(),
                            VB_Status = row["VB_Status"].ToString()
                        };

                        BlacklistList.Add(blacklist);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = BlacklistList;
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
        //5

        public Response ActivateBlacklsit(BlacklistRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "200")
                {
                    result.StatusCode = 200;
                    result.Result = "Status Updated Blacklist Successfully!!";
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
        //
    }
}
