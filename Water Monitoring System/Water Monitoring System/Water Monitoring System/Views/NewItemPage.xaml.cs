using System;
using System.Collections.Generic;
using System.ComponentModel;
using Water_Monitoring_System.Models;
using Water_Monitoring_System.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Water_Monitoring_System.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}