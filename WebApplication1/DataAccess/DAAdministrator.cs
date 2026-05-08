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
    public class DAAdministrator : IAdministrator
    {
        private readonly string ProcedureName = "Administrator_Details";

        public Response AddAdministrator(AdministratorRequestAPI requestAPI)
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

        public Response GetAllAdministrator(AdministratorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdministratorModel> administratorList = new List<AdministratorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdministratorModel administrator = new AdministratorModel
                        {
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VA_Name = row["VA_Name"].ToString(),
                            VA_Role = row["VA_Role"].ToString(),
                            VA_Email = row["VA_Email"].ToString(),
                            VA_Created_Date = row["VA_Created_Date"].ToString(),
                            VA_Created_By = row["VA_Created_By"].ToString(),
                            VA_Update_Date = row["VA_Update_Date"].ToString(),
                            VA_Update_By = row["VA_Update_By"].ToString(),
                            VA_Status = row["VA_Status"].ToString()
                        };

                        administratorList.Add(administrator);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = administratorList;
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

        public Response UpdateAdministrator(AdministratorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdministratorModel> administratorList = new List<AdministratorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdministratorModel administrator = new AdministratorModel
                        {
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VA_Name = row["VA_Name"].ToString(),
                            VA_Role = row["VA_Role"].ToString(),
                            VA_Email = row["VA_Email"].ToString(),
                            VA_Created_Date = row["VA_Created_Date"].ToString(),
                            VA_Created_By = row["VA_Created_By"].ToString(),
                            VA_Update_Date = row["VA_Update_Date"].ToString(),
                            VA_Update_By = row["VA_Update_By"].ToString(),
                            VA_Status = row["VA_Status"].ToString()
                        };

                        administratorList.Add(administrator);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = administratorList;
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

        public Response GetAdministratorById(AdministratorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdministratorModel> administratorList = new List<AdministratorModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdministratorModel administrator = new AdministratorModel
                        {
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VA_Name = row["VA_Name"].ToString(),
                            VA_Role = row["VA_Role"].ToString(),
                            VA_Email = row["VA_Email"].ToString(),
                            VA_Created_Date = row["VA_Created_Date"].ToString(),
                            VA_Created_By = row["VA_Created_By"].ToString(),
                            VA_Update_Date = row["VA_Update_Date"].ToString(),
                            VA_Update_By = row["VA_Update_By"].ToString(),
                            VA_Status = row["VA_Status"].ToString()
                        };

                        administratorList.Add(administrator);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = administratorList;
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

        public Response DeleteAdministrator(AdministratorRequestAPI requestAPI)
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

        public Response LoginAdministrator(AdministratorRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "6";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdministratorLoginModel> administratorList = new List<AdministratorLoginModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdministratorLoginModel administrator = new AdministratorLoginModel
                        {
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VA_Name = row["VA_Name"].ToString(),
                            VA_Role = row["VA_Role"].ToString(),
                            VA_Email = row["VA_Email"].ToString(),
                            VA_Status = row["VA_Status"].ToString()
                        };

                        administratorList.Add(administrator);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = administratorList;
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

