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
    public class AdministratorController : Controller
    {
        private readonly IAdministrator _Administrator;

        public AdministratorController(IAdministrator administrator)
        {
            _Administrator = administrator;
        }

        [HttpPost]
        public ActionResult AddAdministrator(AdministratorRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_Administrator.AddAdministrator(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllAdministrator(AdministratorRequestAPI requestAPI)
        {
            return Json(_Administrator.GetAllAdministrator(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateAdministrator(AdministratorRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_Administrator.UpdateAdministrator(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAdministratorById(AdministratorRequestAPI requestAPI)
        {
            return Json(_Administrator.GetAdministratorById(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteAdministrator(AdministratorRequestAPI requestAPI)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            requestAPI.P_UID = userId;
            return Json(_Administrator.DeleteAdministrator(requestAPI), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult LoginAdministrator(AdministratorRequestAPI requestAPI)
        {
            var loginResult = _Administrator.LoginAdministrator(requestAPI);

            if (loginResult != null && loginResult.StatusCode == 200 && loginResult.ResultSet != null)
            {
                var list = loginResult.ResultSet as List<AdministratorLoginModel>;
                if (list != null && list.Count > 0)
                {
                    string adminId = list[0].VA_Admin_id;
                    string role = list[0].VA_Role;
                    string email = list[0].VA_Email;

                    string authKey = AuthKeyGenerator.GenerateAuthKey(adminId, role, requestAPI.VA_Password, email);

                    HttpContext.Items["UserRole"] = role;
                    HttpContext.Items["UserId"] = adminId;
                    HttpContext.Items["AuthKey"] = authKey;

                    loginResult.ResultSet = new List<AdministratorAuthKeyModel>
                    {
                        new AdministratorAuthKeyModel
                        {
                            VA_Admin_id = adminId,
                            VA_Role = role,
                            VA_Email = email,
                            AuthKey = authKey
                        }
                    };
                }
            }

            return Json(loginResult, JsonRequestBehavior.AllowGet);
        }
    }
}

