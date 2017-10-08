using DibzIt.Pages;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DibzIt {
    public partial class MainPage : ContentPage {

        public DateTime MinimumDate { get; set; }
        public DateTime MaximumDate { get; set; }

        public MainPage() {
            InitializeComponent();
        }

        protected override void OnAppearing() {
            base.OnAppearing();
            DatePicker.MinimumDate = DateTime.Now;
            DatePicker.MaximumDate = DatePicker.MinimumDate.AddDays(6);
        }

        async void OnSearchButtonTapped(object sender, EventArgs e) {

            DateTime selectedDate = DatePicker.Date;
            if (selectedDate == DateTime.Now.Date) {
                selectedDate = DateTime.Now;
            }
            int duration = DurationPicker.SelectedIndex + 1;
            await Navigation.PushAsync(new TimeSlotsPage(selectedDate, duration));
        }
    }
}
