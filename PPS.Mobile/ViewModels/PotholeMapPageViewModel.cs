using System;
using PPS.Mobile.Data.Contracts;
using PPS.Mobile.Data.Models;
using Prism.Events;

namespace PPS.Mobile.ViewModels
{
    public class PotholeMapPageViewModel : ChildViewModelBase
    {
        private IDataService service;
        public PotholeMapPageViewModel(IEventAggregator eventAggregator,IDataService service) : base(eventAggregator)
        {
            Title = "Pothole Map";
            this.service = service;

            var issue = new Issue();
            issue.SubmittedOn = DateTime.UtcNow;

            service.AddIssue(issue);

        }
    }
}
