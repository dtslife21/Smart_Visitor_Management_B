using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicle _Vehicle;

        public VehicleController(IVehicle vehicle)
        {
            _Vehicle = vehicle;
        }

        [HttpGet]
        public ActionResult GetAllVehicles(VehicleRequestAPI requestAPI)
        {
            return Json(_Vehicle.GetAllVehicles(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVehicleById(VehicleRequestAPI requestAPI)
        {
            return Json(_Vehicle.GetVehicleById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetVehicleByNumber(VehicleRequestAPI requestAPI)
        {
            return Json(_Vehicle.GetVehicleByNumber(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddVehicle(VehicleRequestAPI requestAPI)
        {
            
            return Json(_Vehicle.AddVehicle(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateVehicle(VehicleRequestAPI requestAPI)
        {
            
            return Json(_Vehicle.UpdateVehicle(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateVehicleStatus(VehicleRequestAPI requestAPI)
        {
           
            return Json(_Vehicle.UpdateVehicleStatus(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}
