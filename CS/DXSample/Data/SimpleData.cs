using System;
using System.Linq;
using System.Collections.Generic;

namespace DXSample {
    public class SimpleData : SimpleDataBase {

        private bool _Bool;
        private string _Name;
        private int _ID;

        public int ID {
            get { return _ID; }
            set {
                if (_ID == value)
                    return;
                _ID = value;
                OnPropertyChanged(GetPropertyName(() => ID));
            }
        }

        public string Name {
            get { return _Name; }
            set {
                if (_Name == value)
                    return;
                _Name = value;
                OnPropertyChanged(GetPropertyName(() => Name));
            }
        }

        public bool Bool {
            get { return _Bool; }
            set {
                if (_Bool == value)
                    return;
                _Bool = value;
                OnPropertyChanged(GetPropertyName(() => Bool));
            }
        }
    }
}
