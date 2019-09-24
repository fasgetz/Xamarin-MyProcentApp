using ProcentAppXamarin.View;
using ProcentAppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProcentAppXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            datepick.MinimumDate = System.DateTime.Today;
            this.BindingContext = new MainPageViewModel() { Navigation = this.Navigation };         

        }

    }
}
