using System;
namespace PPS.Mobile.Data.Models
{
    public class Issue
    {
        public string IssueId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime SubmittedOn { get; set; }
        public string IssueType { get; set; }
        
    }
}
