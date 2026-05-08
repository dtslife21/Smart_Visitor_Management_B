using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IAlert
    {
        Response AddAlert(AlertRequestAPI requestAPI);
        Response GetAllAlert(AlertRequestAPI requestAPI);

        Response GetByIdAlert(AlertRequestAPI requestAPI);
        Response UpdateAlert(AlertRequestAPI requestAPI);
        Response ActivateAlert(AlertRequestAPI requestAPI);

        // Response GetBlacklistById(BlacklistRequestAPI requestAPI);

    }
}