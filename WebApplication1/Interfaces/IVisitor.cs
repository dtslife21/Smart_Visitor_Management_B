using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IVisitor
    {
        Response AddVisitor(VisitorRequestAPI requestAPI);
        Response UpdateVisitor(VisitorRequestAPI requestAPI);
        Response GetAllVisitors(VisitorRequestAPI requestAPI);
        Response GetVisitorById(VisitorRequestAPI requestAPI);
        Response ActivateVisitor(VisitorRequestAPI requestAPI);
        Response GetVisitorsByContactPerson(VisitorRequestAPI requestAPI);
        //updateK
        Response GetVisitorJointDetails(VisitorRequestAPI requestAPI);
//        Response AddJoinVisitor(VisitorRequestAPI requestAPI);
    }
}

