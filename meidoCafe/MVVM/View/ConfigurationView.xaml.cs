using meidoCafe.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// Interaction logic for ConfigurationView.xaml
    /// </summary>
    public partial class ConfigurationView : UserControl
    {

        internal ObservableCollection<Product> ProdList { get; set; }

        internal ObservableCollection<Category> CategoryList { get; set; }

        public ConfigurationView()
        {
            InitializeComponent();

            using (var ctx = new MeidoContext())
            {
                ProdList = new ObservableCollection<Product>(ctx.Products);
                CategoryList = new ObservableCollection<Category>(ctx.Categories);

                PRemoveComboBox.ItemsSource = ProdList;
                PCategoryComboBox.ItemsSource = CategoryList;
            }
        }

        private void ProductInsert_Click(object sender, RoutedEventArgs e)
        {
            //Inserting a product
            int categoryID = PCategoryComboBox.SelectedIndex + 1;
            string name = PNameTextBox.Text;
            string description = PDescriptionTextBox.Text;
            float price = float.Parse(PPriceTextBox.Text, CultureInfo.InvariantCulture);

            var productToInsert = new Product
            {
                Name = name,
                Description = description,
                CategoryId = categoryID,
                Price = price
            };

            using(var ctx = new MeidoContext())
            {
                ctx.Products.Add(productToInsert);

                ctx.SaveChanges();
            }

            //Clearing inputs after insert
            PCategoryComboBox.SelectedIndex = -1;
            PNameTextBox.Clear();
            PDescriptionTextBox.Clear();
            PPriceTextBox.Clear();
        }

        private void ProductDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
