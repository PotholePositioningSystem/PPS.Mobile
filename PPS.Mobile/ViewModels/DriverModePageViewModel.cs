using System;
using Prism.Events;

namespace PPS.Mobile.ViewModels
{
    public class DriverModePageViewModel : ChildViewModelBase
    {
        public DriverModePageViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Driver Mode";

        }
    }
}
