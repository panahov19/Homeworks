using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShopClient.Messages;

namespace ZooShopClient.ViewModel
{
    internal class RegisterViewModel
    {

        private readonly IMessenger _messenger = new Messenger();

        public RegisterViewModel(IMessenger messenger)
        {
            _messenger = messenger;
        }
       

        public RelayCommand RegisterCommand
        {
            get => new(() =>
            {
                _messenger.Send(new NavigationMessage(typeof(RegisterViewModel)));
            });
        }


    }
}
