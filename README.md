# How to style the month cell using MonthCellLoaded event in Xamarin.Forms Calendar (SfCalendar)

You can style the month cell using the[OnMonthCellLoaded](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfCalendar.XForms~Syncfusion.SfCalendar.XForms.SfCalendar~OnMonthCellLoaded_EV.html) event of [SfCalendar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-calendar) in Xamarin.Forms.

You can also refer the following article.

https://www.syncfusion.com/kb/11863/how-to-style-the-month-cell-using-monthcellloaded-event-in-xamarin-forms-calendar

**C#**

By using the [OnMonthCellLoaded](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfCalendar.XForms~Syncfusion.SfCalendar.XForms.SfCalendar~OnMonthCellLoaded_EV.html)  you can customize the Text, **BackgroudColor** , **BorderColor** and **Font** by using the MonthCellLoadedEventArgs argument

``` c#
this.calendar.OnMonthCellLoaded += Calendar_OnMonthCellLoaded;

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
```

**Output**

![CustomCell](https://github.com/SyncfusionExamples/style-month-cell-calendar-xamarin/blob/master/ScreenShot/CustomCell.png)
