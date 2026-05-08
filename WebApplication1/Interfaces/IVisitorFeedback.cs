using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IVisitorFeedback
    {
        Response AddFeedback(VisitorFeedbackRequestAPI requestAPI);
        Response UpdateFeedback(VisitorFeedbackRequestAPI requestAPI);
        Response GetAllFeedbacks(VisitorFeedbackRequestAPI requestAPI);
        Response GetFeedbackById(VisitorFeedbackRequestAPI requestAPI);
        Response GetFeedbackByVisitorId(VisitorFeedbackRequestAPI requestAPI);
        Response GetFeedbackByGroupId(VisitorFeedbackRequestAPI requestAPI);
        Response UpdateFeedbackStatus(VisitorFeedbackRequestAPI requestAPI);
    }
}