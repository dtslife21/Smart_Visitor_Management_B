using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IBlacklist
    {
        Response AddBlacklist(BlacklistRequestAPI requestAPI);
        Response GetAllBlacklist(BlacklistRequestAPI requestAPI);

        Response GetByIdBlacklist(BlacklistRequestAPI requestAPI);
        Response UpdateBlacklist(BlacklistRequestAPI requestAPI);
        Response ActivateBlacklsit(BlacklistRequestAPI requestAPI);
        //        Response GetBlacklistById(BlacklistRequestAPI requestAPI);

    }
}
