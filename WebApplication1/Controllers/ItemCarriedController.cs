using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class ItemCarriedController : Controller
    {
        private readonly IItemCarried _ItemCarried;

        public ItemCarriedController(IItemCarried itemCarried)
        {
            _ItemCarried = itemCarried;
        }

        [HttpGet]
        public ActionResult GetAllItems(ItemCarriedRequestAPI requestAPI)
        {
            return Json(_ItemCarried.GetAllItems(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetItemById(ItemCarriedRequestAPI requestAPI)
        {
            return Json(_ItemCarried.GetItemById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetItemByName(ItemCarriedRequestAPI requestAPI)
        {
            return Json(_ItemCarried.GetItemByName(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddItem(ItemCarriedRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.VIC_Created_By = userId;
            return Json(_ItemCarried.AddItem(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateItem(ItemCarriedRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.VIC_Update_By = userId;
            return Json(_ItemCarried.UpdateItem(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateItemStatus(ItemCarriedRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.VIC_Update_By = userId;
            return Json(_ItemCarried.UpdateItemStatus(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //UpdateK
        [HttpGet]
        public ActionResult GetItemJoinByGroupMember(ItemCarriedRequestAPI requestAPI)
        //public ActionResult ItemJoin(ItemJoinRequestAPI requestAPI)
        {
            return Json(_ItemCarried.GetItemJoinByGroupMember(requestAPI), JsonRequestBehavior.AllowGet);
        }
       
    }
}
