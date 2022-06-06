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

        public RelayCommand DessertViewCommand { get; set; }

        public RelayCommand ProductViewCommand { get; set; }

        public FoodViewModel FoodVM { get; set; }

        public DrinkViewModel DrinkVM { get; set; }

        public DessertViewModel DessertVM { get; set; }

        public ProductViewModel ProductVM { get; set; }

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
            DessertVM = new DessertViewModel();
            ProductVM = new ProductViewModel();

            CurrentView = FoodVM;

            FoodViewCommand = new RelayCommand(o => { CurrentView = FoodVM; });

            DrinkViewCommand = new RelayCommand(o => { CurrentView = DrinkVM; });

            DessertViewCommand = new RelayCommand(o => { CurrentView = DessertVM; });

            ProductViewCommand = new RelayCommand(o => { CurrentView = ProductVM; });
        }



    }
}
