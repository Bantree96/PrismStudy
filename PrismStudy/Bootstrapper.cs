using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using PrismStudy.Modules.Menus;
using PrismStudy.Modules.TitleBar;
using PrismStudy.ViewModels;
using System.Windows;

namespace PrismStudy
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<TitleBarModule>();
            moduleCatalog.AddModule<MenusModule>();

            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
