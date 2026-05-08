using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class VisitLogController : Controller
    {
        private readonly IVisitLog _VisitLog;

        public VisitLogController(IVisitLog visitLog)
        {
            _VisitLog = visitLog;
        }

        [HttpPost]
        public ActionResult AddVisitLog(VisitLogRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitLog.AddVisitLog(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateVisitLog(VisitLogRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitLog.UpdateVisitLog(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllVisitLogs(VisitLogRequestAPI requestAPI)
        {
            return Json(_VisitLog.GetAllVisitLogs(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitLogById(VisitLogRequestAPI requestAPI)
        {
            return Json(_VisitLog.GetVisitLogById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteVisitLog(VisitLogRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitLog.DeleteVisitLog(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}
