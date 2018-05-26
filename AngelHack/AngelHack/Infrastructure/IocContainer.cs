using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Mvc;


namespace AngelHack.Infrastructure
{
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


}