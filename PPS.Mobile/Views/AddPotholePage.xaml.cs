using System.Reflection;
using PPS.Mobile.Utils;
using PPS.Mobile.ViewModels;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace PPS.Mobile.Views
{
    public partial class AddPotholePage : ContentPage
    {
        public IssueViewModel FormSource { get; set; }

        public AddPotholePage()
        {
            InitializeComponent();

            FormSource = ((IssueViewModel)this.BindingContext);

            this.dataForm.PropertyDataSourceProvider = new UserPropertyDataSourceProvider();

            foreach (var property in typeof(IssueViewModel).GetTypeInfo().DeclaredProperties)
            {
                this.dataForm.RegisterEditor(property.Name, EditorType.Custom);
            }
        }

      
    }
}

