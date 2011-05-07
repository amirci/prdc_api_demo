using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CommonServiceLocator.WindsorAdapter;
using MavenThought.PrDC.Api;
using MavenThought.PrDC.Demo.Controllers;
using Microsoft.Practices.ServiceLocation;

namespace MavenThought.PrDC.Demo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("favicon.ico");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);

            RegisterRoutes(RouteTable.Routes);

            SetupContainer();
        }

        private static void SetupContainer()
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For<IControllerFactory>().ImplementedBy<WindsorControllerFactory>(),
                Component.For<IConference>().ImplementedBy<PrarieDevConConference>(),
                AllTypes
                    .FromThisAssembly()
                    .BasedOn<Controller>()
                    .Configure(reg => reg.LifeStyle.Transient));

            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));

            DependencyResolver.SetResolver(ServiceLocator.Current);
        }
    }
}