using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test.Xamarin
{
    public partial class Avion : ContentPage
    {
        public Avion()
        {
            InitializeComponent();
            avionimage.Opacity = 0;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            avionimage.TranslationX = -250;
            avionimage.TranslationY = -150;
            avionimage.Rotation = 45;
            avionimage.Scale = 0.7;
            avionimage.Opacity = 0;

            anim();
        }

        private async void anim()
        {
            uint length = 800;
            await avionimage.FadeTo(1, 1000);
            await avionimage.TranslateTo(0, 0, length, Easing.SinOut);
            await avionimage.RotateTo(0, length, Easing.SinOut);
            await avionimage.ScaleTo(1, length, Easing.SinOut);
        }
    }
}
