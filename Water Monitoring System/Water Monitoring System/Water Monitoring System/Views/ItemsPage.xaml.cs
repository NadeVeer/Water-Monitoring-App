using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Monitoring_System.Models;
using Water_Monitoring_System.ViewModels;
using Water_Monitoring_System.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Water_Monitoring_System.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}