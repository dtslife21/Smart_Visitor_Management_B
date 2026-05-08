using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IVisitRequest
    {
        Response AddVisitRequest(VisitRequestRequestAPI requestAPI);
        Response UpdateVisitRequest(VisitRequestRequestAPI requestAPI);
        Response GetAllVisitRequests(VisitRequestRequestAPI requestAPI);
        Response GetVisitRequestById(VisitRequestRequestAPI requestAPI);
        Response GetVisitRequestsByContactPerson(VisitRequestRequestAPI requestAPI);
        Response GetVisitRequestsByVisitor(VisitRequestRequestAPI requestAPI);
        Response GetVisitRequestsByDateRange(VisitRequestRequestAPI requestAPI);
        Response ApproveVisitRequest(VisitRequestRequestAPI requestAPI);
        // Response RejectVisitRequest(VisitRequestRequestAPI requestAPI);
        // Response CancelVisitRequest(VisitRequestRequestAPI requestAPI);
        Response GetPendingVisitRequests(VisitRequestRequestAPI requestAPI);
    }
}

