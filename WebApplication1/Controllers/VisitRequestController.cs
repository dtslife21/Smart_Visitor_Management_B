using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class VisitRequestController : Controller
    {
        private readonly IVisitRequest _VisitRequest;

        public VisitRequestController(IVisitRequest visitRequest)
        {
            _VisitRequest = visitRequest;
        }

        [HttpPost]
        public ActionResult AddVisitRequest(VisitRequestRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitRequest.AddVisitRequest(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateVisitRequest(VisitRequestRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitRequest.UpdateVisitRequest(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllVisitRequests(VisitRequestRequestAPI requestAPI)
        {
            return Json(_VisitRequest.GetAllVisitRequests(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitRequestById(VisitRequestRequestAPI requestAPI)
        {
            return Json(_VisitRequest.GetVisitRequestById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitRequestsByContactPerson(VisitRequestRequestAPI requestAPI)
        {
            return Json(_VisitRequest.GetVisitRequestsByContactPerson(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitRequestsByVisitor(VisitRequestRequestAPI requestAPI)
        {
            return Json(_VisitRequest.GetVisitRequestsByVisitor(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitRequestsByDateRange(VisitRequestRequestAPI requestAPI)
        {
            return Json(_VisitRequest.GetVisitRequestsByDateRange(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ApproveVisitRequest(VisitRequestRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitRequest.ApproveVisitRequest(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // [HttpPost]
        // public ActionResult RejectVisitRequest(VisitRequestRequestAPI requestAPI)
        // {
        //     var userId = HttpContext.Items["UserId"]?.ToString();
        //     requestAPI.P_UID = userId;
        //     return Json(_VisitRequest.RejectVisitRequest(requestAPI), JsonRequestBehavior.AllowGet);
        // }

        // [HttpPost]
        // public ActionResult CancelVisitRequest(VisitRequestRequestAPI requestAPI)
        // {
        //     var userId = HttpContext.Items["UserId"]?.ToString();
        //     requestAPI.P_UID = userId;
        //     return Json(_VisitRequest.CancelVisitRequest(requestAPI), JsonRequestBehavior.AllowGet);
        // }

        [HttpGet]
        public ActionResult GetPendingVisitRequests(VisitRequestRequestAPI requestAPI)
        {
            return Json(_VisitRequest.GetPendingVisitRequests(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}

