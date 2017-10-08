using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DibzIt.Pages {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeSlotsPage : ContentPage {

        List<string> timeSlots = new List<string>();

        public TimeSlotsPage(DateTime startDate, int duration) {
            InitializeComponent();
            DateTime fromDateTime = startDate;
            for (int i = startDate.Hour; i < 24; i++) {
                string from = fromDateTime.ToString("hh:00 tt");
                DateTime toDateTime = fromDateTime.AddHours(duration);
                string to = toDateTime.ToString("hh:00 tt");
                timeSlots.Add(from + " - " + to);
                fromDateTime = fromDateTime.AddHours(1);
            }
            TimeSlotsList.ItemsSource = timeSlots;
        }

    }
}