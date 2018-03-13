using System.Collections.ObjectModel;

namespace PPS.Mobile.Droid
{
    public class ViewModel
    {
        public ObservableCollection<DataItem> Items { get; set; }

        public ViewModel()
        {
            this.Items = this.GenerateData(20);
        }

        private ObservableCollection<DataItem> GenerateData(int itemsCount)
        {
            var items = new ObservableCollection<DataItem>();
            for (int i = 1; i <= itemsCount; i++)
            {
                items.Add(new DataItem("Data Item " + i));
            }

            return items;
        }
    }
}
