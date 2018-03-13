using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DryIoc;
using Prism.DryIoc;
using PPS.Mobile.Views;
using PPS.Mobile.Data.Contracts;
using PPS.Mobile.Data.Infrastructure;

namespace PPS.Mobile
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("RootPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<RootPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<UserProfilePage>();
            Container.RegisterTypeForNavigation<AddPotholePage>();
            Container.Register<IDataService, DataService>();
        }
    }
}

