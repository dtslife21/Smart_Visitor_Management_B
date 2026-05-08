using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.BusinessLayer;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class BlacklistController : Controller
    {
        private readonly IBlacklist _Blacklist;

        public BlacklistController(IBlacklist blacklist)
        {
            _Blacklist = blacklist;
        }
        //1. AddBlacklist
        [HttpPost]
        public ActionResult AddBlacklist(BlacklistRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.P_UID = userId;
            return Json(_Blacklist.AddBlacklist(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //2. GetAllBlacklist
        [HttpGet]
        public ActionResult GetAllBlacklist(BlacklistRequestAPI requestAPI)
        {
            return Json(_Blacklist.GetAllBlacklist(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //3.GetByID
        [HttpGet]
        public ActionResult GetByIdBlacklist(BlacklistRequestAPI requestAPI)
        {
            return Json(_Blacklist.GetByIdBlacklist(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //4.UpdateBlacklist
        [HttpPost]
        public ActionResult UpdateBlacklist(BlacklistRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.P_UID = userId;
            return Json(_Blacklist.UpdateBlacklist(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //5.UpdateStatus
        [HttpPost]
        public ActionResult ActivateBlacklsit(BlacklistRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.P_UID = userId;
            return Json(_Blacklist.ActivateBlacklsit(requestAPI), JsonRequestBehavior.AllowGet);
        }

    }
}

