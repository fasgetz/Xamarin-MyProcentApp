using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using ProcentAppXamarin;
using ProcentAppXamarin.Droid;
using ProcentAppXamarin.Droid.CustomControls;
using ProcentAppXamarin.MyControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(DatePickerCtrl), typeof(DatePickerCtrlRenderer))]
namespace ProcentAppXamarin.Droid.CustomControls
{
    public class DatePickerCtrlRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            this.Control.SetTextColor(Android.Graphics.Color.Gray);
            ////this.Control.SetTextColor(Android.Graphics.Color.Rgb(83, 63, 149));
            //this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            //this.Control.SetPadding(20, 0, 0, 0);

            //GradientDrawable gd = new GradientDrawable();
            ////gd.SetCornerRadius(25); //increase or decrease to changes the corner look
            //gd.SetColor(Android.Graphics.Color.Transparent);
            //gd.SetStroke(3, Android.Graphics.Color.Rgb(83, 63, 149));

            //this.Control.SetBackgroundDrawable(gd);

            DatePickerCtrl element = Element as DatePickerCtrl;

            if (!string.IsNullOrWhiteSpace(element.Placeholder))
            {
                Control.Text = element.Placeholder;                
            }

            this.Control.TextChanged += (sender, arg) => {
                this.Control.SetTextColor(Android.Graphics.Color.Black);
                var selectedDate = arg.Text.ToString();
                if (selectedDate == element.Placeholder)
                {
                    Control.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        
                    }
            };
        }
    }
}