using System;
using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace DXSample {
    public class SimpleDataBase : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected static string GetPropertyName<T>(Expression<Func<T>> expression) {
            string propertyName;
            var memberExpression = expression as MemberExpression;
            if (memberExpression != null)
                propertyName = memberExpression.Member.Name;
            else
                propertyName = string.Empty;
            return propertyName;
        }

        protected void OnPropertyChanged(string property) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
