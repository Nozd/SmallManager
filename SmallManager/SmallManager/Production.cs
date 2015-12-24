using System;
using System.Collections.Generic;
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
        //Номер заказа
        private string NumberOrder;
        public string _NumberOrder { get { return NumberOrder; } set { NumberOrder = value; } }
        //Проработка
        private string Analysis;
        public string _Analysis { get { return Analysis; } set { Analysis = value; } }
        //Согласование
        private string Adjustment;
        public string _Adjustment { get { return Adjustment; } set { Adjustment = value; } }
        //Заявка на материалы
        private string RequestMaterials;
        public string _RequestMaterials { get { return RequestMaterials; } set { RequestMaterials = value; } }
        //Чертежи, развёртки
        private string Drawing;
        public string _Drawing { get { return Drawing; } set { Drawing = value; } }
        //Программы
        private string Program;
        public string _Program { get { return Program; } set { Program = value; } }
        //Изготовление
        private stepOfProduct StepOfProduct;
        public stepOfProduct _StepOfProduct { get { return StepOfProduct; } set { StepOfProduct = value; } }
    }
}
