using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin.Behavior
{
    public class CalendarBehavior : Behavior<ContentPage>
    {
        private SfCalendar calendar;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable.FindByName<SfCalendar>("calendar");
            this.calendar.OnMonthCellLoaded += Calendar_OnMonthCellLoaded;
        }

        private void Calendar_OnMonthCellLoaded(object sender, MonthCellLoadedEventArgs args)
        {
            // As default setting Month cell Background color as Green 
           args.BackgroundColor = Color.Green;
           var appointments = calendar.DataSource as CalendarEventCollection;

            for (int i = 0; i < appointments.Count; i++)
            {
                var appointment = appointments[i];
                if (args.Date.Date == appointment.StartTime.Date)
                {
                    // Setting Background color when the appointment available on the specific day 
                    args.BackgroundColor = Color.Red;
                }
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.calendar.OnMonthCellLoaded -= Calendar_OnMonthCellLoaded;
        }
    }
}
