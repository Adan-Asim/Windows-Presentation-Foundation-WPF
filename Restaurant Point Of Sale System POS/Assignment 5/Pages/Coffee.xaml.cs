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
    /// Interaction logic for Coffee.xaml
    /// </summary>
    public partial class Coffee : Page
    {
        public Coffee()
        {
            InitializeComponent();
            seventeen.DataContext = ItemList.IList[16];
            eighteen.DataContext = ItemList.IList[17];
        }
    }
}
