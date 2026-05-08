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
    public class DAContactPerson : IContactPerson
    {
        private readonly string ProcedureName = "ContactPerson_Details";

        public Response AddContactPerson(ContactPersonRequestAPI requestAPI)
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

        public Response UpdateContactPerson(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

        public Response GetAllContactPersons(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

        public Response GetContactPersonById(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

        public Response GetContactPersonByPhone(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

        public Response UpdateContactPersonStatus(ContactPersonRequestAPI requestAPI)
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

        public Response SearchContactPersons(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "7";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

        public Response GetContactPersonByEmail(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "8";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

        public Response GetActiveContactPersons(ContactPersonRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "9";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ContactPersonModel> contactPersonList = new List<ContactPersonModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ContactPersonModel contactPerson = new ContactPersonModel
                        {
                            VCP_Contact_person_id = row["VCP_Contact_person_id"].ToString(),
                            VCP_Name = row["VCP_Name"].ToString(),
                            VCP_Department = row["VCP_Department"].ToString(),
                            VCP_Email = row["VCP_Email"].ToString(),
                            VCP_Phone = row["VCP_Phone"].ToString(),
                            VCP_Created_Date = row["VCP_Created_Date"].ToString(),
                            VCP_Created_By = row["VCP_Created_By"].ToString(),
                            VCP_Update_Date = row["VCP_Update_Date"].ToString(),
                            VCP_Update_By = row["VCP_Update_By"].ToString(),
                            VCP_Status = row["VCP_Status"].ToString()
                        };

                        contactPersonList.Add(contactPerson);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = contactPersonList;
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

