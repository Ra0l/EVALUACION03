using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPage1());

            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GridDemo());

            };
            Item5.Clicked += async (sender, e) =>
            {
                //Call Popup
                await Navigation.PushModalAsync(new DatepickerDemo());

            };

            Item6.Clicked += async (sender, e) =>
            {
                //Call Popup
                var answer = await DisplayAlert("Pregunta?", "Hola profesor Torrico Desea almorzar", "Yes", "No");
                Debug.WriteLine("Answer: " + answer);

            };
        }
    }
}
