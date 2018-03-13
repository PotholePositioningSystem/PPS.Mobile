using System;
using System.Threading.Tasks;
using System.Windows.Input;
using PPS.Mobile.Data.Contracts;
using PPS.Mobile.Data.Models;
using Prism.Events;
using Prism.Navigation;
using Xamarin.Forms;

namespace PPS.Mobile.ViewModels
{
    public class PotholeMapPageViewModel : ChildViewModelBase
    {
        private IDataService service;
        readonly INavigationService navigationService;

        public ICommand PotholeNavigateCommand => new Command(async () => await NavigateToAddPothole());

        public PotholeMapPageViewModel(INavigationService navigationService,IEventAggregator eventAggregator,IDataService service) : base(eventAggregator)
        {
            Title = "Pothole Map";
            this.service = service;
            this.navigationService = navigationService;

          

        }

        public async Task NavigateToAddPothole()
        {
            await navigationService.NavigateAsync("RootPage/AddPotholePage");
        }
    }
}
