﻿using meidoCafe.Models;
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
                var foodList = new ObservableCollection<Product>(ctx.Products.Where(p => p.ProductTypeId.Equals(1)));
            }

            //TODO: Add item loading from list
        }
    }
}
