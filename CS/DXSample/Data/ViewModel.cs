using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DXSample {
    public class ViewModel {

        public ObservableCollection<SimpleData> Collection { get; set; }
        
        public ViewModel() {
            Collection = new ObservableCollection<SimpleData>();
            for (int i = 0; i < 100; i++) {
                Collection.Add(new SimpleData() { 
                    ID = i,
                    Name = "Name"+i,
                    Bool = i % 2 == 0,
                });
            }
        }
    }
}