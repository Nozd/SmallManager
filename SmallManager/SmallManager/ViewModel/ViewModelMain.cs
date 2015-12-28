﻿using System;
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

        /// <summary>
        /// SelectedItem is an object instead of a Person, only because we are allowing "CanUserAddRows=true" 
        /// NewItemPlaceHolder represents a new row, and this is not the same as Person class
        /// 
        /// Change 'object' to 'Person', and you will see the following:
        /// 
        /// System.Windows.Data Error: 23 : Cannot convert '{NewItemPlaceholder}' from type 'NamedObject' to type 'MvvmExample.Model.Person' for 'en-US' culture with default conversions; consider using Converter property of Binding. NotSupportedException:'System.NotSupportedException: TypeConverter cannot convert from MS.Internal.NamedObject.
        ///   at System.ComponentModel.TypeConverter.GetConvertFromException(Object value)
        ///   at System.ComponentModel.TypeConverter.ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
        ///   at MS.Internal.Data.DefaultValueConverter.ConvertHelper(Object o, Type destinationType, DependencyObject targetElement, CultureInfo culture, Boolean isForward)'
        ///System.Windows.Data Error: 7 : ConvertBack cannot convert value '{NewItemPlaceholder}' (type 'NamedObject'). BindingExpression:Path=SelectedPerson; DataItem='ViewModelMain' (HashCode=47403907); target element is 'DataGrid' (Name=''); target property is 'SelectedItem' (type 'Object') NotSupportedException:'System.NotSupportedException: TypeConverter cannot convert from MS.Internal.NamedObject.
        ///   at MS.Internal.Data.DefaultValueConverter.ConvertHelper(Object o, Type destinationType, DependencyObject targetElement, CultureInfo culture, Boolean isForward)
        ///   at MS.Internal.Data.ObjectTargetConverter.ConvertBack(Object o, Type type, Object parameter, CultureInfo culture)
        ///   at System.Windows.Data.BindingExpression.ConvertBackHelper(IValueConverter converter, Object value, Type sourceType, Object parameter, CultureInfo culture)'
        /// </summary>

        object _SelectedCalc;
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
            //People = new ObservableCollection<Person>
            //{
            //    new Calculation() { FirstName="Tom", LastName="Jones", Age=80 },
            //    new Person { FirstName="Dick", LastName="Tracey", Age=40 },
            //    new Person { FirstName="Harry", LastName="Hill", Age=60 },
            //};
            TextProperty1 = "Type here";

            AddUserCommand = new RelayCommand(AddUser);
        }

        void AddUser(object parameter)
        {
            if (parameter == null) return;
            Calc.Add(new Calculation
            {
                NumberOrder = parameter.ToString(),
                Analysis = parameter.ToString(),
                Adjustment = parameter.ToString()
                //FirstName = parameter.ToString(), LastName = parameter.ToString(), Age = DateTime.Now.Second
            });
        }

    }
}
