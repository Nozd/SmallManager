using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SmallManager.Data
{
    class DemoFakeDB
    {
        #region CalculationList
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
        #endregion
        #region ProductionList
        private ObservableCollection<Production> _ProductionList = null;

        public ObservableCollection<Production> ProductionList
        {
            get
            {
                if (_ProductionList != null)
                {
                    return _ProductionList;
                }
                else
                {
                    _ProductionList = new ObservableCollection<Production>();
                    _ProductionList.Add(new Production()
                    {
                        NumberOrder = "12",
                        Analysis = "Беспалов",
                        Adjustment = "Согласовано",
                        RequestMaterials = "Заявка у секретарю",
                        Drawing = "В локальной сети",
                        Program = "Программы отданы в цех",
                        StepOfProduct = stepOfProduct.В_производстве
                    });
                    _ProductionList.Add(new Production()
                    {
                        NumberOrder = "152",
                        Analysis = "Беспалов, Жук",
                        Adjustment = "На согласовании",
                        RequestMaterials = "Не подавалась",
                        Drawing = "",
                        Program = "",
                        StepOfProduct = stepOfProduct.Не_запущена_в_производство
                    });
                    return _ProductionList;
                }
            }
        }
        #endregion
    }
}
