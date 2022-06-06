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
    /// Interaction logic for DrinkView.xaml
    /// </summary>
    public partial class DrinkView : UserControl
    {
        public DrinkView()
        {
            InitializeComponent();

            using (var ctx = new MeidoContext())
            {
                int featured1 = 0;
                int featured2 = 2;

                var drinkList = new ObservableCollection<Product>(ctx.Products.Where(p => p.CategoryId.Equals(2)));

                Featured1Text.Text = drinkList[featured1].Name;
                Featured1Price.Text = $"${drinkList[featured1].Price}";

                Featured2Text.Text = drinkList[featured2].Name;
                Featured2Price.Text = $"${drinkList[featured2].Price}";

                drinkList.Remove(drinkList[featured1]);
                drinkList.Remove(drinkList[featured2 - 1]);

                icFoodItemsControl.ItemsSource = drinkList;
            }
        }
    }
}
