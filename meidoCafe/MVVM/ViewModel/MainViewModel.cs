using meidoCafe.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meidoCafe.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public FoodViewModel FoodVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            FoodVM = new FoodViewModel();
            CurrentView = FoodVM;
        }

    }
}
