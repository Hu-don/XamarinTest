using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test.Xamarin.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void LoadCounterPage(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ViewCount());
        }

        void LoadTabPage(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

         void LoadListPage(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListePage());
        }
    }
}
