using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IGatePass
    {
        Response AddGatePass(GatePassRequestAPI requestAPI);
        Response UpdateGatePass(GatePassRequestAPI requestAPI);
        Response GetAllGatePasses(GatePassRequestAPI requestAPI);
        Response GetGatePassById(GatePassRequestAPI requestAPI);
        Response GetGatePassesByVisitorId(GatePassRequestAPI requestAPI);
        Response GetGatePassByRequestId(GatePassRequestAPI requestAPI);
        Response UpdateGatePassStatus(GatePassRequestAPI requestAPI);
        Response GetActiveGatePasses(GatePassRequestAPI requestAPI);
        Response GetGatePassesByDateRange(GatePassRequestAPI requestAPI);
    }
}
