using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallManager
{
    public enum stepOfProduct
    {
        Не_запущена_в_производство = 0,
        В_производстве = 1,
        Изготовлена = 2
    } ;

    class Production
    {
        #region fields
        //Номер заказа
        private string _NumberOrder;
        public string NumberOrder { get { return _NumberOrder; } set { _NumberOrder = value; } }
        //Проработка
        private string _Analysis;
        public string Analysis { get { return _Analysis; } set { _Analysis = value; } }
        //Согласование
        private string _Adjustment;
        public string Adjustment { get { return _Adjustment; } set { _Adjustment = value; } }
        //Заявка на материалы
        private string _RequestMaterials;
        public string RequestMaterials { get { return _RequestMaterials; } set { _RequestMaterials = value; } }
        //Чертежи, развёртки
        private string _Drawing;
        public string Drawing { get { return _Drawing; } set { _Drawing = value; } }
        //Программы
        private string _Program;
        public string Program { get { return _Program; } set { _Program = value; } }
        //Изготовление
        private stepOfProduct _StepOfProduct;
        public stepOfProduct StepOfProduct { get { return _StepOfProduct; } set { _StepOfProduct = value; } }
        #endregion 
        //Коллекция _ProductionList
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
                        _NumberOrder = "12",
                        _Analysis = "Беспалов",
                        _Adjustment = "Согласовано",
                        _RequestMaterials = "Заявка у секретарю",
                        _Drawing = "В локальной сети",
                        _Program = "Программы отданы в цех",
                        _StepOfProduct = stepOfProduct.В_производстве
                    });
                    _ProductionList.Add(new Production()
                    {
                        _NumberOrder = "152",
                        _Analysis = "Беспалов, Жук",
                        _Adjustment = "На согласовании",
                        _RequestMaterials = "Не подавалась",
                        _Drawing = "",
                        _Program = "",
                        _StepOfProduct = stepOfProduct.Не_запущена_в_производство
                    });
                    return _ProductionList;
                }
            }
        }
    }
}
