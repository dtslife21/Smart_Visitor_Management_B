using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class VisitGroupController : Controller
    {
        private readonly IVisitGroup _VisitGroup;
        // GET: VisitGroup
        public VisitGroupController(IVisitGroup VisitGroup)
        {
            _VisitGroup = VisitGroup;

        }
        //1. Add Visit Group
        [HttpPost]
        public ActionResult AddVisitGroup(VisitGroupRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            //  requestAPI.P_UID = userId;
            return Json(_VisitGroup.AddVisitGroup(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //2. Update Visit Group
        [HttpPost]
        public ActionResult UpdateVisitGroup(VisitGroupRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            // requestAPI.P_UID = userId;
            return Json(_VisitGroup.UpdateVisitGroup(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //3. Update Visit Group Status
        [HttpGet]
        public ActionResult GetAllVisitGroup(VisitGroupRequestAPI requestAPI)
        {
            return Json(_VisitGroup.GetAllVisitGroup(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //4. Get Visit Group By Id
        [HttpGet]
        public ActionResult GetVisitGroupById(VisitGroupRequestAPI requestAPI)
        {
            return Json(_VisitGroup.GetVisitGroupById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        //5. Get Visit Group By Name
        [HttpPost]
        public ActionResult GetActiveVisitGroup(VisitGroupRequestAPI requestAPI)
        {
            return Json(_VisitGroup.GetActiveVisitGroup(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}