using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismStudy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStudy.Modules.Menus
{
    public class MenusModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenusModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.MenuRegion, nameof(Views.Menus));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.Menus>();
        }
    }
}
