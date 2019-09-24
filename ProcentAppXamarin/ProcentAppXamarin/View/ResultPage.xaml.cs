using ProcentAppXamarin.Models;
using ProcentAppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProcentAppXamarin.View
{
    public partial class ResultPage : ContentPage
    {

        public ResultPage(MainPageModel model)
        {
            InitializeComponent();

            this.BindingContext = new ResultPageViewModel(model);
        }
    }
}