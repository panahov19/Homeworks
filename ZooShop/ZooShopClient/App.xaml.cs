using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZooShopClient.View;
using ZooShopClient.ViewModel;

namespace ZooShopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static Container Container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            MainStartup();
           
            base.OnStartup(e);
        }

        private void Register()
        {
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<RegisterViewModel>();
            Container.RegisterSingleton<LoginViewModel>();
        }

        private void MainStartup()
        {
            var mainView = new MainView();
            mainView.DataContext = Container?.GetInstance<LoginViewModel>();
            mainView.ShowDialog();
        }

    }
}
