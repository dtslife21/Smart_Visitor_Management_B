using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Controllers
{
    public class ContactPersonController : Controller
    {
        private readonly IContactPerson _ContactPerson;

        public ContactPersonController(IContactPerson contactPerson)
        {
            _ContactPerson = contactPerson;
        }

        [HttpPost]
        public ActionResult AddContactPerson(ContactPersonRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_ContactPerson.AddContactPerson(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateContactPerson(ContactPersonRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_ContactPerson.UpdateContactPerson(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllContactPersons(ContactPersonRequestAPI requestAPI)
        {
            return Json(_ContactPerson.GetAllContactPersons(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetContactPersonById(ContactPersonRequestAPI requestAPI)
        {
            return Json(_ContactPerson.GetContactPersonById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetContactPersonByPhone(ContactPersonRequestAPI requestAPI)
        {
            return Json(_ContactPerson.GetContactPersonByPhone(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateContactPersonStatus(ContactPersonRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_ContactPerson.UpdateContactPersonStatus(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SearchContactPersons(ContactPersonRequestAPI requestAPI)
        {
            return Json(_ContactPerson.SearchContactPersons(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetContactPersonByEmail(ContactPersonRequestAPI requestAPI)
        {
            return Json(_ContactPerson.GetContactPersonByEmail(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetActiveContactPersons(ContactPersonRequestAPI requestAPI)
        {
            return Json(_ContactPerson.GetActiveContactPersons(requestAPI), JsonRequestBehavior.AllowGet);
        }
    }
}

