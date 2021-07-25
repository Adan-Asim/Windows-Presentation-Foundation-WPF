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
using Assignment_5;

namespace Assignment_5.Pages
{
    /// <summary>
    /// Interaction logic for All.xaml
    /// </summary>
    public partial class All : Page
    {
        public All()
        {
            InitializeComponent();
            ItemList.initialize();

            one.DataContext = ItemList.IList[0];
            two.DataContext = ItemList.IList[1];
            three.DataContext = ItemList.IList[2];
            four.DataContext = ItemList.IList[3];
            five.DataContext = ItemList.IList[4];
            six.DataContext = ItemList.IList[5];
            seven.DataContext = ItemList.IList[6];
            eight.DataContext = ItemList.IList[7];
            nine.DataContext = ItemList.IList[8];
            ten.DataContext = ItemList.IList[9];
            eleven.DataContext = ItemList.IList[10];
            twelve.DataContext = ItemList.IList[11];
            thirteen.DataContext = ItemList.IList[12];
            fourteen.DataContext = ItemList.IList[13];
            fifteen.DataContext = ItemList.IList[14];
            sixteen.DataContext = ItemList.IList[15];
            seventeen.DataContext = ItemList.IList[16];
            eighteen.DataContext = ItemList.IList[17];
            ninteen.DataContext = ItemList.IList[18];
            twenty.DataContext = ItemList.IList[19];
        }
    }
}
