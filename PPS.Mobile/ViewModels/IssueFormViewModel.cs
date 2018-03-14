using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace PPS.Mobile.ViewModels
{
    public class IssueFormViewModel:NotifyPropertyChangedBase
    {
        int severity;
        string comment;
        string location;
        [ReadOnly]
        DateTime submittedOn = DateTime.UtcNow;

        [DisplayOptions(Position = 0, ColumnSpan = 2, PlaceholderText = "Location", Group = "Issue")]
        [NonEmptyValidatorAttribute("Location is required!")]
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                    this.OnPropertyChanged();
                }
            }
        }


        [DisplayOptions(Header = "Submitted At", Position = 2, ColumnPosition = 1, PlaceholderText = "Time", Group = "Issue")]
        [DisplayValueFormat(Time = "hh:mm tt")]
        [NativeConversionContext(DateTimeKind.Local)]
        public DateTime SubmittedAt
        {
            get
            {
                return this.submittedOn;
            }
            set
            {
                if (this.submittedOn != value)
                {
                    this.submittedOn = value;
                    this.OnPropertyChanged();
                }
            }
        }


        [DisplayOptions(Header = "Submitted On", Position = 1, ColumnPosition = 1, PlaceholderText = "Date", Group = "Issue")]
        [DisplayValueFormat(Date = "MMMM dd, yyyy")]
        [NativeConversionContext(DateTimeKind.Local)]
        public DateTime SubmittedOn
        {
            get
            {
                return this.submittedOn;
            }
            set
            {
                if (this.submittedOn != value)
                {
                    this.submittedOn = value;
                    this.OnPropertyChanged();
                }
            }
        }







    }
}
