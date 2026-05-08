using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IAdministrator
    {
        Response AddAdministrator(AdministratorRequestAPI requestAPI);
        Response GetAllAdministrator(AdministratorRequestAPI requestAPI);
        Response UpdateAdministrator(AdministratorRequestAPI requestAPI);
        Response GetAdministratorById(AdministratorRequestAPI requestAPI);
        Response DeleteAdministrator(AdministratorRequestAPI requestAPI);
        Response LoginAdministrator(AdministratorRequestAPI requestAPI);
    }
}

