using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class VisitorController : Controller
    {
        private readonly IVisitor _Visitor;

        public VisitorController(IVisitor visitor)
        {
            _Visitor = visitor;
        }

        [HttpPost]
        public ActionResult AddVisitor(VisitorRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_Visitor.AddVisitor(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateVisitor(VisitorRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_Visitor.UpdateVisitor(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllVisitors(VisitorRequestAPI requestAPI)
        {
            return Json(_Visitor.GetAllVisitors(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitorById(VisitorRequestAPI requestAPI)
        {
            return Json(_Visitor.GetVisitorById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ActivateVisitor(VisitorRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_Visitor.ActivateVisitor(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVisitorsByContactPerson(VisitorRequestAPI requestAPI)
        {
            return Json(_Visitor.GetVisitorsByContactPerson(requestAPI), JsonRequestBehavior.AllowGet);
        }
        //UpdateK
        //Join AT8
        [HttpGet]
        public ActionResult VisitorJoint(VisitorRequestAPI requestAPI)
        {

            return Json(_Visitor.GetVisitorJointDetails(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public ActionResult AddJoinVisitor(VisitorRequestAPI requestAPI)
        //{
        //    // POST VISITOR (ActionType 9)
        //    return Json(_Visitor.AddJoinVisitor(requestAPI), JsonRequestBehavior.AllowGet);
        //}

    }
}

