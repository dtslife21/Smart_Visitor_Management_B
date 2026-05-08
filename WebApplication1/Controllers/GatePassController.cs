using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class GatePassController : Controller
    {
        private readonly IGatePass _GatePass;

        public GatePassController(IGatePass gatePass)
        {
            _GatePass = gatePass;
        }

        [HttpPost]
        public ActionResult AddGatePass(GatePassRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_GatePass.AddGatePass(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateGatePass(GatePassRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_GatePass.UpdateGatePass(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllGatePasses(GatePassRequestAPI requestAPI)
        {
            return Json(_GatePass.GetAllGatePasses(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetGatePassById(GatePassRequestAPI requestAPI)
        {
            return Json(_GatePass.GetGatePassById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetGatePassesByVisitorId(GatePassRequestAPI requestAPI)
        {
            return Json(_GatePass.GetGatePassesByVisitorId(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetGatePassByRequestId(GatePassRequestAPI requestAPI)
        {
            return Json(_GatePass.GetGatePassByRequestId(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateGatePassStatus(GatePassRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_GatePass.UpdateGatePassStatus(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetActiveGatePasses(GatePassRequestAPI requestAPI)
        {
            return Json(_GatePass.GetActiveGatePasses(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetGatePassesByDateRange(GatePassRequestAPI requestAPI)
        {
            return Json(_GatePass.GetGatePassesByDateRange(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}
