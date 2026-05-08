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
    public class DAAdminItemList : IAdminItemList
    {
        private readonly string ProcedureName = "Admin_Item_List_Details";

        //AT1 add
        public Response AddAdminItemList(AdminItemListRequestAPI requestAPI)
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

        //2 update
        public Response UpdateItemNameByItemId(AdminItemListRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "2";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    result.StatusCode = 200;
                    result.Result = "Admin List Update Successfully!!";
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

        //3 get all 
        public Response GetAllAdminItemsList(AdminItemListRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "3";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdminItemListModel> adminitemList = new List<AdminItemListModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdminItemListModel item = new AdminItemListModel
                        {
                            VAIL_Item_List_ID = row["VAIL_Item_List_ID"].ToString(),
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VAIL_Item_Name = row["VAIL_Item_Name"].ToString(),
                            VAIL_Created_Date = row["VAIL_Created_Date"].ToString(),
                            VAIL_Created_By = row["VAIL_Created_By"].ToString(),
                            VAIL_Update_Date = row["VAIL_Update_Date"].ToString(),
                            VAIL_Update_By = row["VAIL_Update_By"].ToString(),
                            VAIL_Status = row["VAIL_Status"].ToString(),
                        };
                        adminitemList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = adminitemList;
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


        public Response GetByItemID (AdminItemListRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "4";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdminItemListModel> adminitemList = new List<AdminItemListModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdminItemListModel item = new AdminItemListModel
                        {
                            VAIL_Item_List_ID = row["VAIL_Item_List_ID"].ToString(),
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VAIL_Item_Name = row["VAIL_Item_Name"].ToString(),
                            VAIL_Created_Date = row["VAIL_Created_Date"].ToString(),
                            VAIL_Created_By = row["VAIL_Created_By"].ToString(),
                            VAIL_Update_Date = row["VAIL_Update_Date"].ToString(),
                            VAIL_Update_By = row["VAIL_Update_By"].ToString(),
                            VAIL_Status = row["VAIL_Status"].ToString(),
                        };
                        adminitemList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = adminitemList;
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
        /*
        public Response GetByItemID (AdminItemListRequestAPI requestAPI)
        {
            Response result = new Response();
            requestAPI.ActionType = "5";

            using (var dbConnect = new DBconnect())
            {
                ProcedureDBModel res = dbConnect.ProcedureRead(requestAPI, ProcedureName);
                if (res.ResultStatusCode == "1")
                {
                    List<AdminItemListModel> adminitemList = new List<AdminItemListModel>();
                    foreach (DataRow row in res.ResultDataTable.Rows)
                    {
                        AdminItemListModel item = new AdminItemListModel
                        {
                            VAIL_Item_List_ID = row["VAIL_Item_List_ID"].ToString(),
                            VA_Admin_id = row["VA_Admin_id"].ToString(),
                            VAIL_Item_Name = row["VAIL_Item_Name"].ToString(),
                            VAIL_Created_Date = row["VAIL_Created_Date"].ToString(),
                            VAIL_Created_By = row["VAIL_Created_By"].ToString(),
                            VAIL_Update_Date = row["VAIL_Update_Date"].ToString(),
                            VAIL_Update_By = row["VAIL_Update_By"].ToString(),
                            VAIL_Status = row["VAIL_Status  "].ToString(),
                        };
                        adminitemList.Add(item);
                    }

                    result.StatusCode = 200;
                    result.ResultSet = adminitemList;
                }
                else
                {
                    LogHandler.WriteToLog(res.ExceptionMessage, System.Reflection.MethodBase.GetCurrentMethod().Name);
                    result.StatusCode = 500;
                    result.Result = string.IsNullOrEmpty(res.ExceptionMessage) ? res.Result : res.ExceptionMessage;
                }

                return result;
            }
        }*/
        public Response UpdateStatusByItemID (AdminItemListRequestAPI requestAPI)
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


