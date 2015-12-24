using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallManager
{
    class Calculation
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

    }
}
