using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using ZooShopClient.Model;
using System.Windows.Navigation;
using ZooShopClient.Messages;
using System.ComponentModel;

namespace ZooShopClient.ViewModel
{





    class MainViewModel : ViewModelBase
    {


        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel { get => currentViewModel; 
            set
            {
                Set(ref currentViewModel, value);
                currentViewModel = value;
            } 
        }




        private readonly IMessenger _messenger;

        public MainViewModel(IMessenger messenger)
        {
            _messenger = messenger;
            _messenger.Register<NavigationMessage>(this, message =>
           {
               CurrentViewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
           });
        }


    }

}

