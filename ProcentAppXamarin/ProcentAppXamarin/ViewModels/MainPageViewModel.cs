using Android.App;
using ProcentAppXamarin.Models;
using ProcentAppXamarin.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProcentAppXamarin.ViewModels
{
    public class MainPageViewModel : VMBase
    {
        #region Свойства

        private MainPageModel model;
        public INavigation Navigation { get; set; }
        public ICommand test { get; }

        public ulong StartSum
        {
            get => model.StartSum;
            set
            {
                model.StartSum = value;
                OnPropertyChanged("StartSum");
            }
        }

        public double Procent
        {
            get
            {
                return model.Procent;
            }
            set
            {
                model.Procent = value;
                OnPropertyChanged("Procent");
            }
        }

        public ulong Capitalize
        {
            get => model.Capitalize;
            set
            {
                model.Capitalize = value;
                OnPropertyChanged("Capitalize");
            }
        }

        public ulong PutOffSum
        {
            get => model.PutOffSum;
            set
            {
                model.PutOffSum = value;
                OnPropertyChanged("PutOffSum");
            }
        }

        public DateTime EndDate
        {
            get => model.EndDate;
            set
            {
                model.EndDate = value;
                OnPropertyChanged("EndDate");
            }
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Метод проверяет на заполнение необходимых свойств
        /// </summary>
        /// <returns>Возвращает true, если необходимые свойства заполнены</returns>
        private bool IsPropertiesRequired()
        {
            return (!(model.StartSum == 0) && !(model.Procent == 0) && !(model.EndDate == DateTime.MinValue));
        }

        #endregion

        #region Команды

        public async void GoToResultPage()
        {
            if (IsPropertiesRequired())
                await Navigation.PushAsync(new ResultPage(model));
            else
                await App.Current.MainPage.DisplayAlert("Ошибка", "Заполните необходимые поля", "ОК");
        }

        #endregion

        public MainPageViewModel()
        {
            model = new MainPageModel();

            test = new Command(GoToResultPage);
        }
    }
}
