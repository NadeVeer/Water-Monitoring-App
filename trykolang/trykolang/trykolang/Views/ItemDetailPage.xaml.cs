using System.ComponentModel;
using trykolang.ViewModels;
using Xamarin.Forms;

namespace trykolang.Views
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