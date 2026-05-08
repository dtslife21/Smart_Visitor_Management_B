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
    public class DAVehicle : IVehicle
    {
        private readonly string ProcedureName = "Vehicle_Details";

        public Response GetAllVehicles(VehicleRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "1";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VehicleModel> vehicleList = new List<VehicleModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VehicleModel vehicle = new VehicleModel
                        {
                            VV_Vehicle_id = row["VV_Vehicle_id"].ToString(),
                            VV_Vehicle_Number = row["VV_Vehicle_Number"].ToString(),
                            VV_Vehicle_Type = row["VV_Vehicle_Type"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Status = row["VV_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };
                        vehicleList.Add(vehicle);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = vehicleList;
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

        public Response GetVehicleById(VehicleRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VehicleModel> vehicleList = new List<VehicleModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VehicleModel vehicle = new VehicleModel
                        {
                            VV_Vehicle_id = row["VV_Vehicle_id"].ToString(),
                            VV_Vehicle_Number = row["VV_Vehicle_Number"].ToString(),
                            VV_Vehicle_Type = row["VV_Vehicle_Type"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Status = row["VV_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };
                        vehicleList.Add(vehicle);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = vehicleList;
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

        public Response GetVehicleByNumber(VehicleRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VehicleModel> vehicleList = new List<VehicleModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VehicleModel vehicle = new VehicleModel
                        {
                            VV_Vehicle_id = row["VV_Vehicle_id"].ToString(),
                            VV_Vehicle_Number = row["VV_Vehicle_Number"].ToString(),
                            VV_Vehicle_Type = row["VV_Vehicle_Type"].ToString(),
                            VV_Created_Date = row["VV_Created_Date"].ToString(),
                            VV_Created_By = row["VV_Created_By"].ToString(),
                            VV_Update_Date = row["VV_Update_Date"].ToString(),
                            VV_Update_By = row["VV_Update_By"].ToString(),
                            VV_Status = row["VV_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };
                        vehicleList.Add(vehicle);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = vehicleList;
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

        public Response AddVehicle(VehicleRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

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

        public Response UpdateVehicle(VehicleRequestAPI requestAPI)
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

        public Response UpdateVehicleStatus(VehicleRequestAPI requestAPI)
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
    }
}
