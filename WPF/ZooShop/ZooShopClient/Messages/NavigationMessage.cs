using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShopClient.Messages
{
    internal class NavigationMessage
    {
        public Type ViewModelType { get; set; }


        public NavigationMessage(Type  viewModel)
        {
            ViewModelType = viewModel;
        }


    }
}
