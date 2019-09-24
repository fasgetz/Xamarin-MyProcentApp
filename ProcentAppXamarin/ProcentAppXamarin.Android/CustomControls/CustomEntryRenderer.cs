using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProcentAppXamarin.Droid.CustomControls;
using ProcentAppXamarin.MyControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace ProcentAppXamarin.Droid.CustomControls
{

    
        public class CustomEntryRenderer : EntryRenderer
        {
            public CustomEntryRenderer(Context context) : base(context) { }
            protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
            {
                base.OnElementChanged(e); if (Control == null || Element == null) return; var element = (CustomEntry)Element; var isNumeric = element.IsNumeric; if (isNumeric)
                { // Force the keyboard to be numeric without sign Control.KeyListener = new DigitsKeyListener(false,true); } } } } 
                } } } } 