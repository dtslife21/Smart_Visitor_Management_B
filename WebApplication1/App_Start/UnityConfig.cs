using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebApplication1.Interfaces;
using WebApplication1.DataAccess;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Register your interfaces and implementations
            container.RegisterType<ITest, DATest>();
            container.RegisterType<IUser, DAUser>();
            container.RegisterType<IEmployee, DAEmployee>();
            container.RegisterType<IAdministrator, DAAdministrator>();
            container.RegisterType<IVisitor, DAVisitor>();
            container.RegisterType<IVisitRequest, DAVisitRequest>();
            container.RegisterType<IContactPerson, DAContactPerson>();
            container.RegisterType<IGatePass, DAGatePass>();
            container.RegisterType<IVehicle, DAVehicle>();
            container.RegisterType<IItemCarried, DAItemCarried>();
            container.RegisterType<IBlacklist, DABlacklist>();
            container.RegisterType<IAlert, DAAlert>();
            container.RegisterType<IVisitLog, DAVisitLog>();
            container.RegisterType<IVisitGroup, DAVisitGroup>();
            container.RegisterType<IAdminItemList, DAAdminItemList>();
            container.RegisterType<IVisitorFeedback, DAVisitorFeedback>();

            // Set the dependency resolver for MVC
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
