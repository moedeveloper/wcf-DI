using Microsoft.Practices.Unity;
using Unity.Wcf;
using SkfAptitude.Resolver;

namespace SKFAptitude.Wcf
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            // register all your components with the container here
            //container.RegisterType<IService1, Service1>(new HierarchicalLifetimeManager());

            ComponentLoader.LoadContainer(container, ".\\bin", "SKFAptitude.Wcf.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "SkfAptitude.BusinessServices.dll");
        }
    }    
}