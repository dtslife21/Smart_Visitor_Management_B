using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class VisitorFeedbackController : Controller
    {
        private readonly IVisitorFeedback _VisitorFeedback;

        public VisitorFeedbackController(IVisitorFeedback visitorFeedback)
        {
            _VisitorFeedback = visitorFeedback;
        }

        // AT1 - Add
        [HttpPost]
        public ActionResult AddFeedback(VisitorFeedbackRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
         // if (!string.IsNullOrEmpty(userId))      

                requestAPI.P_UID = userId;
            return Json(_VisitorFeedback.AddFeedback(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // AT2 - Update
        [HttpPost]
        public ActionResult UpdateFeedback(VisitorFeedbackRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitorFeedback.UpdateFeedback(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // AT3 - Get All
        [HttpGet]
        public ActionResult GetAllFeedbacks(VisitorFeedbackRequestAPI requestAPI)
        {
            return Json(_VisitorFeedback.GetAllFeedbacks(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // AT4 - Get By Feedback ID
        [HttpGet]
        public ActionResult GetFeedbackById(VisitorFeedbackRequestAPI requestAPI)
        {
            return Json(_VisitorFeedback.GetFeedbackById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // AT5 - Get By Visitor ID
        [HttpGet]
        public ActionResult GetFeedbackByVisitorId(VisitorFeedbackRequestAPI requestAPI)
        {
            return Json(_VisitorFeedback.GetFeedbackByVisitorId(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // AT6 - Get By Group ID
        [HttpGet]
        public ActionResult GetFeedbackByGroupId(VisitorFeedbackRequestAPI requestAPI)
        {
            return Json(_VisitorFeedback.GetFeedbackByGroupId(requestAPI), JsonRequestBehavior.AllowGet);
        }

        // AT7 - Change Status
        [HttpPost]
        public ActionResult UpdateFeedbackStatus(VisitorFeedbackRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_VisitorFeedback.UpdateFeedbackStatus(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}