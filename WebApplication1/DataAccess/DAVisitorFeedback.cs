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
    public class DAVisitorFeedback : IVisitorFeedback
    {
        private readonly string ProcedureName = "Visitor_Feedback_Details";

        // AT1 - Add Feedback
        public Response AddFeedback(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "1";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Feedback Added Successfully!!";
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

        // AT2 - Update Feedback
        public Response UpdateFeedback(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Feedback Updated Successfully!!";
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

        // AT3 - Get All Feedbacks
        public Response GetAllFeedbacks(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorFeedbackModel> feedbackList = new List<VisitorFeedbackModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorFeedbackModel feedback = new VisitorFeedbackModel
                        {
                            VVF_Feedback_Id = row["VVF_Feedback_Id"].ToString(),
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VVG_id = row["VVG_id"].ToString(),
                            VVF_Feedback_Description = row["VVF_Feedback_Description"].ToString(),
                            VVF_Created_Date = row["VVF_Created_Date"].ToString(),
                            VVF_Created_By = row["VVF_Created_By"].ToString(),
                            VVF_Update_Date = row["VVF_Update_Date"].ToString(),
                            VVF_Update_By = row["VVF_Update_By"].ToString(),
                            VVF_Status = row["VVF_Status"].ToString()
                        };
                        feedbackList.Add(feedback);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = feedbackList;
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

        // AT4 - Get By Feedback ID
        public Response GetFeedbackById(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorFeedbackModel> feedbackList = new List<VisitorFeedbackModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorFeedbackModel feedback = new VisitorFeedbackModel
                        {
                            VVF_Feedback_Id = row["VVF_Feedback_Id"].ToString(),
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VVG_id = row["VVG_id"].ToString(),
                            VVF_Feedback_Description = row["VVF_Feedback_Description"].ToString(),
                            VVF_Created_Date = row["VVF_Created_Date"].ToString(),
                            VVF_Created_By = row["VVF_Created_By"].ToString(),
                            VVF_Update_Date = row["VVF_Update_Date"].ToString(),
                            VVF_Update_By = row["VVF_Update_By"].ToString(),
                            VVF_Status = row["VVF_Status"].ToString()
                        };
                        feedbackList.Add(feedback);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = feedbackList;
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

        // AT5 - Get By Visitor ID
        public Response GetFeedbackByVisitorId(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorFeedbackModel> feedbackList = new List<VisitorFeedbackModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorFeedbackModel feedback = new VisitorFeedbackModel
                        {
                            VVF_Feedback_Id = row["VVF_Feedback_Id"].ToString(),
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VVG_id = row["VVG_id"].ToString(),
                            VVF_Feedback_Description = row["VVF_Feedback_Description"].ToString(),
                            VVF_Created_Date = row["VVF_Created_Date"].ToString(),
                            VVF_Created_By = row["VVF_Created_By"].ToString(),
                            VVF_Update_Date = row["VVF_Update_Date"].ToString(),
                            VVF_Update_By = row["VVF_Update_By"].ToString(),
                            VVF_Status = row["VVF_Status"].ToString()
                        };
                        feedbackList.Add(feedback);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = feedbackList;
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

        // AT6 - Get By Group ID
        public Response GetFeedbackByGroupId(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "6";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<VisitorFeedbackModel> feedbackList = new List<VisitorFeedbackModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        VisitorFeedbackModel feedback = new VisitorFeedbackModel
                        {
                            VVF_Feedback_Id = row["VVF_Feedback_Id"].ToString(),
                            VV_Visitor_id = row["VV_Visitor_id"].ToString(),
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VVG_id = row["VVG_id"].ToString(),
                            VVF_Feedback_Description = row["VVF_Feedback_Description"].ToString(),
                            VVF_Created_Date = row["VVF_Created_Date"].ToString(),
                            VVF_Created_By = row["VVF_Created_By"].ToString(),
                            VVF_Update_Date = row["VVF_Update_Date"].ToString(),
                            VVF_Update_By = row["VVF_Update_By"].ToString(),
                            VVF_Status = row["VVF_Status"].ToString()
                        };
                        feedbackList.Add(feedback);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = feedbackList;
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

        // AT7 - Update Status
        public Response UpdateFeedbackStatus(VisitorFeedbackRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "7";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = res.Result;
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