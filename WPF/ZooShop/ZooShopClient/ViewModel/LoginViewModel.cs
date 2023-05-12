using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShopClient.Messages;

namespace ZooShopClient.ViewModel
{



    internal class LoginViewModel : ViewModelBase
    {

        private readonly IMessenger _messenger = new Messenger();

        public LoginViewModel(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public RelayCommand LoginCommand
        {

            get => new(() =>
            {
                _messenger.Send(new NavigationMessage(typeof(LoginViewModel)));
            });

        }
    }

}




    

