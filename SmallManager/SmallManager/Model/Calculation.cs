using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallManager
{
    class Calculation
    {
        //Номер заявки
        private string _NumberOrder;
        public string NumberOrder { get { return _NumberOrder; } set { _NumberOrder = value; } }
        //Проработка
        private string _Analysis;
        public string Analysis { get { return _Analysis; } set { _Analysis = value; } }
        //Согласование
        private string _Adjustment;
        public string Adjustment { get { return _Adjustment; } set { _Adjustment = value; } }
        //Коллекция CalculationList
        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
       

    }
}
