using ProcentAppXamarin.Models;
using ProcentAppXamarin.ProgramLogic;
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

        public ulong StartCapital
        {
            get => model.StartSum;
        }
        public double _EarnedSum;
        public double EarnedSum
        {
            get => _EarnedSum;
            set
            {
                _EarnedSum = value;
                OnPropertyChanged("EarnedSum");
            }
        }

        public double _AllCapital;
        public double AllCapital
        {
            get => _AllCapital;
            set
            {
                _AllCapital = value;
                OnPropertyChanged("AllCapital");
            }
        }

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

        public ResultPageViewModel(MainPageModel model)
        {
            this.model = model;

            ProcentLogic logic = new ProcentLogic();
            mylist = logic.StartInvest(model);

            EarnedSum = logic.EarnedSum;
            AllCapital = logic.AllCapital;
        }
    }
}
