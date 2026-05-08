using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IVisitLog
    {
        Response AddVisitLog(VisitLogRequestAPI requestAPI);
        Response UpdateVisitLog(VisitLogRequestAPI requestAPI);
        Response GetAllVisitLogs(VisitLogRequestAPI requestAPI);
        Response GetVisitLogById(VisitLogRequestAPI requestAPI);
        Response DeleteVisitLog(VisitLogRequestAPI requestAPI);
    }
}
