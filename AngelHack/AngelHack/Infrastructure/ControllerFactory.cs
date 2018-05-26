using Castle.Windsor;
using System.Web.Mvc;
using System;


namespace AngelHack.Infrastructure
{
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