using Shop.UIForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.UIForms.Infrastruture
{
    class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
 