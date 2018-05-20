using AngelHack.DataLayer;
using AngelHack.DataLayer.Repo;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Mvc;
using System;
using System.Web;
using System.Web.Routing;
using Castle.MicroKernel;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AngelHack.App_Start
{
    public class IocConfig
    {
        public class ControllersInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                container.Register(AllTypes.FromThisAssembly()
                    .Pick().If(t => t.Name.EndsWith("Controller"))
                    .Configure(configurer => configurer.Named(configurer.Implementation.Name))
                    .LifestylePerWebRequest());
            }
        }
    }

    public class BusinessLogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<IAppDbContex>().ImplementedBy<AppDbContext>().LifestylePerWebRequest());
            container.Register(Component.For<IBookingRepository>().ImplementedBy<BookingRepository>().LifestylePerWebRequest());
        }
    }


    public static class IocContainer
    {
        private static IWindsorContainer _container;

        public static void Setup()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());

            ControllerFactory controllerFactory = new ControllerFactory(_container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }

    public class ControllerFactory : DefaultControllerFactory
    {
        private readonly IWindsorContainer container;

        public ControllerFactory(IWindsorContainer container)
        {
            this.container = container;
        }

        public override void ReleaseController(IController controller)
        {
            container.Release(controller.GetType());
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return (IController)container.Resolve(controllerType);
        }
    }


}