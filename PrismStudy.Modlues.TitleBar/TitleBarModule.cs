using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismStudy.Core;
using PrismStudy.Modlues.TitleBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStudy.Modules.TitleBar
{
    public class TitleBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public TitleBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.TitleBarRegion, "TitleBar");

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.TitleBar,TitleBarViewModel>();

        }
    }
}
