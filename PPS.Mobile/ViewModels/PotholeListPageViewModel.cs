using System;
using Prism.Events;

namespace PPS.Mobile.ViewModels
{
    public class PotholeListPageViewModel : ChildViewModelBase
    {
        public PotholeListPageViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Potholes";

        }
    }
}
