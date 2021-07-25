using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_5.Pages
{
    /// <summary>
    /// Interaction logic for Icecream.xaml
    /// </summary>
    public partial class Icecream : Page
    {
        public Icecream()
        {
            InitializeComponent();
            thirteen.DataContext = ItemList.IList[12];
            fourteen.DataContext = ItemList.IList[13];
            fifteen.DataContext = ItemList.IList[14];
        }
    }
}
