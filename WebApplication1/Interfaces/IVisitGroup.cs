using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;


namespace WebApplication1.Interfaces
{
    public interface IVisitGroup
    {
        Response AddVisitGroup(VisitGroupRequestAPI requestAPI);
        Response UpdateVisitGroup(VisitGroupRequestAPI requestAPI);
        Response GetAllVisitGroup(VisitGroupRequestAPI requestAPI);
        Response GetVisitGroupById(VisitGroupRequestAPI requestAPI);
        Response GetActiveVisitGroup(VisitGroupRequestAPI requestAPI);

    }
}
