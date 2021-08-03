using Categoryio.Destkop.Services.Navigation;
using Categoryio.Destkop.ViewModels;
using TinyIoC;

namespace Categoryio.Destkop.IoC
{
    public class DIHelper
    {
        private static TinyIoCContainer _container;

        static DIHelper()
        {
            _container = new TinyIoCContainer();

            // View models - by default, TinyIoC will register concrete classes as multi-instance.
            _container.Register<MainViewModel>();

            // Services - by default, TinyIoC will register interface registrations as singletons.
            _container.Register<INavigationService, NavigationService>();
           
        }

        public static void RegisterSingleton<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            _container.Register<TInterface, T>().AsSingleton();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
