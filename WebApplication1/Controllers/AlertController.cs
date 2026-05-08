using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLayer;
using WebApplication1.DataAccess;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class AlertController : Controller
    {
        private readonly IAlert _Alert;

        public AlertController(IAlert alert)
        {
            _Alert = alert;
        }
        //1. Add_Alert
        [HttpPost]
        public ActionResult AddAlert(AlertRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.P_UID = userId;
            return Json(_Alert.AddAlert(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //2. GetAllAlert
        [HttpGet]
        public ActionResult GetAllAlert(AlertRequestAPI requestAPI)
        {
            return Json(_Alert.GetAllAlert(requestAPI), JsonRequestBehavior.AllowGet);
        }
        //3 get by id
        [HttpGet]
        public ActionResult GetByIdAlert(AlertRequestAPI requestAPI)
        {
            return Json(_Alert.GetByIdAlert(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //4.UpdateBlacklist
        [HttpPost]
        public ActionResult UpdateAlert(AlertRequestAPI requestAPI)
        {

            return Json(_Alert.UpdateAlert(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //5.UpdateStatus
        [HttpPost]
        public ActionResult ActivateAlert(AlertRequestAPI requestAPI)
        {
            //var userId = HttpContext.Items["UserId"]?.ToString();
            //requestAPI.P_UID = userId;
            return Json(_Alert.ActivateAlert(requestAPI), JsonRequestBehavior.AllowGet);
        }

    }
}