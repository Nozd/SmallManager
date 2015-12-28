using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallManager.Data;

namespace SmallManager
{
    class ViewModelMain: ViewModelBase
    {
        public ObservableCollection<Calculation> Calc { get; set; }
        public ObservableCollection<Production> Prod { get; set; }

        object _SelectedCalc;
        object _SelectedProd;
        public object SelectedCalc
        {
            get
            {
                return _SelectedCalc;
            }
            set
            {
                if (_SelectedCalc != value)
                {
                    _SelectedCalc = value;
                    RaisePropertyChanged("SelectedCalc");
                }
            }
        }
        public object SelectedProd
        {
            get
            {
                return _SelectedProd;
            }
            set
            {
                if (_SelectedProd != value)
                {
                    _SelectedProd = value;
                    RaisePropertyChanged("SelectedProd");
                }
            }
        }

        string _TextProperty1;

        public string TextProperty1
        {
            get
            {
                return _TextProperty1;
            }
            set
            {
                if (_TextProperty1 != value)
                {
                    _TextProperty1 = value;
                    RaisePropertyChanged("TextProperty1");
                }
            }
        }

        public RelayCommand AddUserCommand { get; set; }

        public ViewModelMain()
        {
            DemoFakeDB demoFakeDb = new DemoFakeDB();
            Calc = demoFakeDb.CalculationList;
            Prod = demoFakeDb.ProductionList;
            TextProperty1 = "Type here";

            //AddUserCommand = new RelayCommand(AddUser);
        }

        //void AddUser(object parameter)
        //{
        //    if (parameter == null) return;
        //    Calc.Add(new Calculation
        //    {
        //        NumberOrder = parameter.ToString(),
        //        Analysis = parameter.ToString(),
        //        Adjustment = parameter.ToString()
        //        //FirstName = parameter.ToString(), LastName = parameter.ToString(), Age = DateTime.Now.Second
        //    });
        //}

    }
}
