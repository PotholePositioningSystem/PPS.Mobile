using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace PPS.Mobile.Views
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            this.chart.Annotations.Add(new CartesianGridLineAnnotation { Axis = this.verticalAxis, Value = 10000, Stroke = Device.OnPlatform(Color.FromHex("0071BC"), Color.FromHex("0071BC"), Color.White), StrokeThickness = 1 });
            Device.OnPlatform(Android: () => this.areaSeries.StrokeThickness = 0, WinPhone: () => this.areaSeries.StrokeThickness = 0);
        }
    }
}
