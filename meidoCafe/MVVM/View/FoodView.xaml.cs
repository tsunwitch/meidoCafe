using meidoCafe.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace meidoCafe.MVVM.View
{
    /// <summary>
    /// Interaction logic for FoodView.xaml
    /// </summary>
    public partial class FoodView : UserControl
    {
        public FoodView()
        {
            InitializeComponent();

            using(var ctx = new MeidoContext())
            {
                int featured1 = 2;
                int featured2 = 4;

                var foodList = new ObservableCollection<Product>(ctx.Products.Where(p => p.CategoryId.Equals(1)));

                Featured1Text.Text = foodList[featured1].Name;
                Featured1Price.Text = $"${foodList[featured1].Price}";

                Featured2Text.Text = foodList[featured2].Name;
                Featured2Price.Text = $"${foodList[featured2].Price}";

                foodList.Remove(foodList[featured1]);
                foodList.Remove(foodList[featured2 - 1]);

                icFoodItemsControl.ItemsSource = foodList;
            }

            //TODO: Add item loading from list
            
        }
    }
}
