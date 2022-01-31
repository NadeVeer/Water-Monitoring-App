using System.ComponentModel;
using Water_Monitoring_System.ViewModels;
using Xamarin.Forms;

namespace Water_Monitoring_System.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}