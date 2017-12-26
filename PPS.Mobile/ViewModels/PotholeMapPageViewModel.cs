using System;
using Prism.Events;

namespace PPS.Mobile.ViewModels
{
    public class PotholeMapPageViewModel : ChildViewModelBase
    {
        public PotholeMapPageViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Pothole Map";

        }
    }
}
