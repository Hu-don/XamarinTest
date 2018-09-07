using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test.Xamarin.Views
{
    public partial class ViewCount : ContentPage
    {

        int number = 0;

        public ViewCount()
        {
            InitializeComponent();
            countLabel.Text = number.ToString();
        }

        void CountButtonClicked(object sender, System.EventArgs e)
        {
            number++;
            countLabel.Text = number.ToString();
        }
    }
}
