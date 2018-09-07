using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test.Xamarin
{
    public partial class Voiture : ContentPage
    {
        public Voiture()
        {
            InitializeComponent();
            voitureimage.Opacity = 1;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            voitureimage.Opacity = 1;
            voitureimage.FadeTo(0, 1000);
        }

    }
}
