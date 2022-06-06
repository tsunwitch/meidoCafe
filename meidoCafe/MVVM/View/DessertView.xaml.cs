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
    /// Interaction logic for DessertView.xaml
    /// </summary>
    public partial class DessertView : UserControl
    {
        public DessertView()
        {
            InitializeComponent();

            using (var ctx = new MeidoContext())
            {
                int featured1 = 1;
                int featured2 = 2;

                var dessertList = new ObservableCollection<Product>(ctx.Products.Where(p => p.CategoryId.Equals(3)));

                Featured1Text.Text = dessertList[featured1].Name;
                Featured1Price.Text = $"${dessertList[featured1].Price}";

                Featured2Text.Text = dessertList[featured2].Name;
                Featured2Price.Text = $"${dessertList[featured2].Price}";

                dessertList.Remove(dessertList[featured1]);
                dessertList.Remove(dessertList[featured2 - 1]);

                icFoodItemsControl.ItemsSource = dessertList;
            }
        }
    }
}
