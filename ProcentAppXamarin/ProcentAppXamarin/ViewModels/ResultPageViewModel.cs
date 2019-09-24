using ProcentAppXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProcentAppXamarin.ViewModels
{
    class ResultPageViewModel : VMBase
    {
        #region Свойства

        private MainPageModel model;

        private List<Result> _mylist;
        public List<Result> mylist
        {
            get => _mylist;
            set
            {
                _mylist = value;
                OnPropertyChanged("mylist");
            }
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Стартовый метод для вычислений
        /// </summary>
        private void StartInvesting(MainPageModel model)
        {
            double residue = 0; // Остаточная сумма
            double startcap = model.StartSum; // Стартовый капитал
        }

        #endregion

        public ResultPageViewModel(MainPageModel model)
        {
            this.model = model;
            mylist = new List<Result>();
            int s = 0;

            for (int i = 0; i <= 30; i++)
            {
                //Random r = new Random();
                //r.Next(0, 100);


                Result res = new Result() { numb = s += 1000, name = "Olegser" };
                mylist.Add(res); 
            }          
        }
    }
}
