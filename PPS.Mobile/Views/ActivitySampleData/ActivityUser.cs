using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PPS.Mobile.Views
{
    public class ActivityUser
    {
        public ActivityUser(string name, bool isMale, double height, double weight, int age)
        {
            this.Name = name;
            this.IsMale = isMale;
            this.Height = height;
            this.Weight = weight;
            this.Age = age;
            this.Data = this.GenerateWeeklyData();
            this.Photo = ImageSource.FromResource("PPS.Mobile.Views.ActivitySampleData.user.png");
        }

        public string Name { get; set; }
        public bool IsMale { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public ObservableCollection<ActivityData> Data { get; set; }
        public ImageSource Photo { get; set; }

        private ObservableCollection<ActivityData> GenerateWeeklyData()
        {
            var randomGenerator = new Random();
            var data = new ObservableCollection<ActivityData>();
            for (int i = 0; i < 7; i++)
            {
                var activityData = new ActivityData();
                var steps = randomGenerator.Next(7000, 12000);
                var duration = TimeSpan.FromMinutes(steps / 115);
                activityData.Date = DateTime.Today.AddDays(-i);
                activityData.Duration = duration;
                activityData.Steps = steps;
                activityData.CaloriesBurned = Math.Round(5 * this.Weight * duration.TotalHours);
                activityData.Distance = (steps * (this.Height * (this.IsMale ? 0.415 : 0.413))) / 100;
                data.Add(activityData);
            }

            return data;
        }

        // Step Length Men = Height_CM * 0.415
        // Step Length Ladies = Height_CM * 0.413
    }
}
