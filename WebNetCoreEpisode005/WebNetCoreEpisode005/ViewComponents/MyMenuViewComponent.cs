using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebNetCoreEpisode005.ViewComponents
{    
    public class MyMenuViewComponent: ViewComponent
    {
        private IEnumerable<Menu> _menus;

        public MyMenuViewComponent()
        {
            _menus = new List<Menu>
            {
                new Menu { MenuText = "Create Form v1", ActionName = "Create", ControllerName = "Home" },
                new Menu { MenuText = "Create Form v2", ActionName = "CreateV2", ControllerName = "Home" }
            };
        }

        public async Task<IViewComponentResult> InvokeAsync(string brandName)
        {
            ViewData["BrandName"] = brandName;

            return View(_menus);
        }
    }

    public class Menu
    {
        public string MenuText { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
    }
}
