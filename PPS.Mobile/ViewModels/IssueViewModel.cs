using System;
using System.ComponentModel;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace PPS.Mobile.ViewModels
{
    public class IssueViewModel:NotifyPropertyChangedBase
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

        [DisplayOptions(Position = 3, ColumnSpan = 2, PlaceholderText = "Comment", Group = "Issue")]
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                if (this.comment != value)
                {
                    this.comment = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Severity", Position = 4, ColumnPosition = 1, PlaceholderText = "How would you rank the severity of this pothole from 1-10?", Group = "Issue")]
        [DataSourceKey(nameof(Severity))]
        public int Severity
        {
            get
            {
                return this.severity;
            }
            set
            {
                if (this.severity != value)
                {
                    this.severity = value;
                    this.OnPropertyChanged();
                }
            }
        }

    }
}
