using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Calculation> _CalculationList = null;

        public ObservableCollection<Calculation> CalculationList
        {
            get
            {
                if (_CalculationList != null)
                {
                    return _CalculationList;
                }
                //else
                //{
                    _CalculationList = new ObservableCollection<Calculation>();
                    _CalculationList.Add(new Calculation()
                    {
                        NumberOrder = "10-Пр",
                        Analysis = "Жук",
                        Adjustment = "Отправлена 10.12.2015г."
                    });
                    _CalculationList.Add(new Calculation()
                    {
                        NumberOrder = "15-Пр",
                        Analysis = "Беспалов А.В.",
                        Adjustment = "Согласовано"
                    });
                    _CalculationList.Add(new Calculation()
                    {
                        NumberOrder = "441",
                        Analysis = "Василькин",
                        Adjustment = ""
                    });
                    return _CalculationList;
                //}
            }
        }

    }
}
