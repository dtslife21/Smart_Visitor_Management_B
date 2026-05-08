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
    public class DAItemCarried : IItemCarried
    {
        private readonly string ProcedureName = "Item_Carried_Details";

        public Response GetAllItems(ItemCarriedRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "1";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ItemCarriedModel> itemList = new List<ItemCarriedModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ItemCarriedModel item = new ItemCarriedModel
                        {
                            VIC_Item_id = row["VIC_Item_id"].ToString(),
                            VIC_Item_Name = row["VIC_Item_Name"].ToString(),
                            VIC_Quantity = row["VIC_Quantity"].ToString(),
                            VIC_Designation = row["VIC_Designation"].ToString(),
                            VIC_Created_Date = row["VIC_Created_Date"].ToString(),
                            VIC_Created_By = row["VIC_Created_By"].ToString(),
                            VIC_Update_Date = row["VIC_Update_Date"].ToString(),
                            VIC_Update_By = row["VIC_Update_By"].ToString(),
                            VIC_Status = row["VIC_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };
                        itemList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = itemList;
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

        public Response GetItemById(ItemCarriedRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ItemCarriedModel> itemList = new List<ItemCarriedModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ItemCarriedModel item = new ItemCarriedModel
                        {
                            VIC_Item_id = row["VIC_Item_id"].ToString(),
                            VIC_Item_Name = row["VIC_Item_Name"].ToString(),
                            VIC_Quantity = row["VIC_Quantity"].ToString(),
                            VIC_Designation = row["VIC_Designation"].ToString(),
                            VIC_Created_Date = row["VIC_Created_Date"].ToString(),
                            VIC_Created_By = row["VIC_Created_By"].ToString(),
                            VIC_Update_Date = row["VIC_Update_Date"].ToString(),
                            VIC_Update_By = row["VIC_Update_By"].ToString(),
                            VIC_Status = row["VIC_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };
                        itemList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = itemList;
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

        public Response GetItemByName(ItemCarriedRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<ItemCarriedModel> itemList = new List<ItemCarriedModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ItemCarriedModel item = new ItemCarriedModel
                        {
                            VIC_Item_id = row["VIC_Item_id"].ToString(),
                            VIC_Item_Name = row["VIC_Item_Name"].ToString(),
                            VIC_Quantity = row["VIC_Quantity"].ToString(),
                            VIC_Designation = row["VIC_Designation"].ToString(),
                            VIC_Created_Date = row["VIC_Created_Date"].ToString(),
                            VIC_Created_By = row["VIC_Created_By"].ToString(),
                            VIC_Update_Date = row["VIC_Update_Date"].ToString(),
                            VIC_Update_By = row["VIC_Update_By"].ToString(),
                            VIC_Status = row["VIC_Status"].ToString(),
                            VVR_Request_id = row["VVR_Request_id"].ToString()
                        };
                        itemList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = itemList;
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

        public Response AddItem(ItemCarriedRequestAPI requestAPI)
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

        public Response UpdateItem(ItemCarriedRequestAPI requestAPI)
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

        public Response UpdateItemStatus(ItemCarriedRequestAPI requestAPI)
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

        //UpdatedK
        public Response GetItemJoinByGroupMember(ItemCarriedRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "7";

            using (var dbConnect = new DBconnect())
            {
                // IMPORTANT: Ensure ProcedureRead is accepting 'requestAPI' 
                // as the 'ItemJoinRequestAPI' type you just defined.
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);

                if (res.ResultStatusCode == "1")
                {
                    List<ItemJoinModel> itemJoinList = new List<ItemJoinModel>();

                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        ItemJoinModel item = new ItemJoinModel
                        {
                            Visitor_Name = row["Visitor_Name"].ToString(),
                            Contact_person_id = row["Contact_person_id"].ToString(),
                            Visitor_NIC_Passport_NO = row["Visitor_NIC_Passport_NO"].ToString(),
                            Request_id = row["Request_id"].ToString(),
                            Visitor_id = row["Visitor_id"].ToString(),
                            Group_Member_ID = row["Group_Member_ID"].ToString(),
                            Group_Members = row["Group_Members"].ToString(),
                            Members_NIC_Passport_Number = row["Members_NIC_Passport_Number"].ToString(),
                            Item_Id = row["Item_Id"].ToString(),
                            Item_Name = row["Item_Name"].ToString(),
                            Item_Quantity = row["Item_Quantity"].ToString(),
                            Item_Description = row["Item_Description"].ToString(),
                            //Group_Member_ID = row["Group_Member_ID"].ToString()
                        };
                        itemJoinList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = itemJoinList;
                    result.Result = "Success!!";
                }
                else
                {
                    result.StatusCode = 500;
                    result.Result = res.ExceptionMessage;
                }

                return result;
            }
        }
        public Response AddJoinItem(ItemCarriedRequestAPI requestAPI)
        {
            Response result = new Response();

            requestAPI.ActionType = "8";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);

                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Item POST Insert Success!!";
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

    }
}
