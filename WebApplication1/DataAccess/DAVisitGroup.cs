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
    public class DAVisitGroup : IVisitGroup
    {
        private readonly string ProcedureName = "Visit_Group_Details";

        //1. Add Visit Group
        public Response AddVisitGroup(VisitGroupRequestAPI requestAPI)
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

                    result.ResultSet = new
                    {
                        VGIdParam = res.VGIdParam
                    };
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
        }
        //2. Update Visit Group
        public Response UpdateVisitGroup(VisitGroupRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitGroupModel> VisitGroupList = new List<VisitGroupModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitGroupModel VisitGroup = new VisitGroupModel
                        {
                            //VVG_id = row["VVG_id"].ToString(),
                            VVG_Visitor_Name = row["VVG_Visitor_Name"].ToString(),
                            VVG_NIC_Passport_Number = row["VVG_NIC_Passport_Number"].ToString(),
                            VVG_Designation = row["VVG_Designation"].ToString(),
                            //          VVG_Created_Date = row["VVG_Created_Date"].ToString(),
                            //        VVG_Created_By = row["VVG_Created_By"].ToString(),
                            VVG_Update_Date = row["VVG_Update_Date"].ToString(),
                            VVG_Update_By = row["VVG_Update_By"].ToString(),
                            VVG_Status = row["VVG_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()

                        };

                        VisitGroupList.Add(VisitGroup);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = VisitGroupList;
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
        //3. Get All Visit Group
        public Response GetAllVisitGroup(VisitGroupRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitGroupModel> VisitGroupList = new List<VisitGroupModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitGroupModel VisitGroup = new VisitGroupModel
                        {
                            VVG_id = row["VVG_id"].ToString(),
                            VVG_Visitor_Name = row["VVG_Visitor_Name"].ToString(),
                            VVG_NIC_Passport_Number = row["VVG_NIC_Passport_Number"].ToString(),
                            VVG_Designation = row["VVG_Designation"].ToString(),
                            VVG_Created_Date = row["VVG_Created_Date"].ToString(),
                            VVG_Created_By = row["VVG_Created_By"].ToString(),
                            VVG_Update_Date = row["VVG_Update_Date"].ToString(),
                            VVG_Update_By = row["VVG_Update_By"].ToString(),
                            VVG_Status = row["VVG_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };

                        VisitGroupList.Add(VisitGroup);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = VisitGroupList;
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

        //4. Get Visit Group By Id
        public Response GetVisitGroupById(VisitGroupRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitGroupModel> VisitGroupList = new List<VisitGroupModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitGroupModel VisitGroup = new VisitGroupModel
                        {
                            VVG_id = row["VVG_id"].ToString(),
                            VVG_Visitor_Name = row["VVG_Visitor_Name"].ToString(),
                            VVG_NIC_Passport_Number = row["VVG_NIC_Passport_Number"].ToString(),
                            VVG_Designation = row["VVG_Designation"].ToString(),
                            VVG_Created_Date = row["VVG_Created_Date"].ToString(),
                            VVG_Created_By = row["VVG_Created_By"].ToString(),
                            VVG_Update_Date = row["VVG_Update_Date"].ToString(),
                            VVG_Update_By = row["VVG_Update_By"].ToString(),
                            VVG_Status = row["VVG_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };

                        VisitGroupList.Add(VisitGroup);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = VisitGroupList;
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
        //5. Update Visit Group Status
        public Response GetActiveVisitGroup(VisitGroupRequestAPI requestAPI)
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
