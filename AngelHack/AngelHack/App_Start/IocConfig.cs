using AngelHack.Model.Contract;
using AngelHack.Model.Implementation;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace AngelHack.DataLayer.Contract
{

    public class IocConfig
    {
        public class ControllersInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                container.Register(
                    AllTypes.FromThisAssembly()
                    .Pick()
                    .If(t => t.Name.EndsWith("Controller"))
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
            container.Register(Component.For<IMembershipRepository>().ImplementedBy<MembershipRepository>().LifestylePerWebRequest());
            container.Register(Component.For<ISpaceRepository>().ImplementedBy<SpaceRepository>().LifestylePerWebRequest());
        }
    }
}