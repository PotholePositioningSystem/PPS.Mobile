using System;

namespace PPS.Mobile.Views
{
    public class ActivityData
    {
        public double CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public double Distance { get; set; }
        public TimeSpan Duration { get; set; }
        public int Steps { get; set; }
    }
}