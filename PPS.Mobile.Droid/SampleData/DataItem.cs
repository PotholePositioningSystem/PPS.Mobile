using Xamarin.Forms;

namespace PPS.Mobile.Droid
{
    public class DataItem
    {
        private string dummyText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

        public DataItem(string name)
        {
            this.Name = name;
            this.ShortTitle = this.Name;
            this.LongTitle = this.Name + ": " + this.dummyText;
            this.ShortDescription = "This is description of " + this.ShortTitle;
            this.LongDescription = "This is description of " + this.ShortTitle + ". " + this.dummyText;
            this.ImagePath = ImageSource.FromResource("PPS.Mobile.Droid.SampleData.placeholder.png");
        }

        public string Name { get; set; }
        public string ShortTitle { get; set; }
        public string LongTitle { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public ImageSource ImagePath { get; set; }
    }
}
