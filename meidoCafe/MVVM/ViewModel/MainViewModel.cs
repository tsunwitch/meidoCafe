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
        public RelayCommand FoodViewCommand { get; set; }

        public RelayCommand DrinkViewCommand { get; set; }

        public FoodViewModel FoodVM { get; set; }

        public DrinkViewModel DrinkVM { get; set; }

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
            DrinkVM = new DrinkViewModel();

            CurrentView = FoodVM;

            FoodViewCommand = new RelayCommand(o => { CurrentView = FoodVM; });

            DrinkViewCommand = new RelayCommand(o => { CurrentView = DrinkVM; });
        }



    }
}
