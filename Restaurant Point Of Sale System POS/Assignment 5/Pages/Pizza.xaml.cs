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
    /// Interaction logic for Pizza.xaml
    /// </summary>
    public partial class Pizza : Page
    {
        public Pizza()
        {
            InitializeComponent();

            four.DataContext = ItemList.IList[3];
            five.DataContext = ItemList.IList[4];
            six.DataContext = ItemList.IList[5];
            seven.DataContext = ItemList.IList[6];
        }
    }
}
