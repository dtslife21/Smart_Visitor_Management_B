using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DataAccess;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class AdminItemListController : Controller
    {
        // GET: AdminItemList
        private readonly IAdminItemList _IAdminItemList;

        public AdminItemListController(IAdminItemList adminItemList)
        {
            _IAdminItemList = adminItemList;
        }
        //1
        [HttpPost]
        public ActionResult AddAdminItemList(AdminItemListRequestAPI requestAPI)
        {
            return Json(_IAdminItemList.AddAdminItemList(requestAPI), JsonRequestBehavior.AllowGet);
        }
        //2
        [HttpPost]
        public ActionResult UpdateItemNameByItemId (AdminItemListRequestAPI requestAPI)
        {
            return Json(_IAdminItemList.UpdateItemNameByItemId(requestAPI), JsonRequestBehavior.AllowGet);
        }
        //3
        [HttpGet]
        public ActionResult GetAllAdminItemsList (AdminItemListRequestAPI requestAPI)
        {
            return Json(_IAdminItemList.GetAllAdminItemsList(requestAPI), JsonRequestBehavior.AllowGet);
        }
        //4
        [HttpGet]
        public ActionResult GetByItemID (AdminItemListRequestAPI requestAPI)
        {
            return Json(_IAdminItemList.GetByItemID(requestAPI), JsonRequestBehavior.AllowGet);
        }
        //5
        [HttpPost]
        public ActionResult UpdateStatusByItemID (AdminItemListRequestAPI requestAPI)
        {
            return Json(_IAdminItemList.UpdateStatusByItemID (requestAPI), JsonRequestBehavior.AllowGet);
        }


    }
}