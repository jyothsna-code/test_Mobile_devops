﻿
using Autofac;
using Xamarin.Forms;

namespace Cryptollet.Modules.AddTransaction
{
    public partial class AddTransactionView : ContentPage
    {
        public AddTransactionView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<AddTransactionViewModel>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await(BindingContext as AddTransactionViewModel).InitializeAsync(null);
        }
    }
}
