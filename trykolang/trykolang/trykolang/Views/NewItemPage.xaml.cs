using System;
using System.Collections.Generic;
using System.ComponentModel;
using trykolang.Models;
using trykolang.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trykolang.Views
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