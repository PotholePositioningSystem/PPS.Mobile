using System;
using System.Linq;

namespace PPS.Mobile.Views
{
    public class ActivityViewModel
    {
        public ActivityUser CurrentUser { get; set; }
        public ActivityData TodaysData { get; set; }
        public double AverageSteps
        {
            get
            {
                var stepsSum = this.CurrentUser.Data.Sum(d => d.Steps);
                return stepsSum / this.CurrentUser.Data.Count;
            }
        }

        public ActivityViewModel()
        {
            this.CurrentUser = new ActivityUser("John Adams", true, 184, 80, 31);
            this.TodaysData = this.CurrentUser.Data.FirstOrDefault(d => d.Date.Date == DateTime.Today.Date);
        }
    }
}
