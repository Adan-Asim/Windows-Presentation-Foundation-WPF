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
    /// Interaction logic for Tile.xaml
    /// </summary>
    public partial class Tile : UserControl
    {
        public Tile()
        {
            InitializeComponent();
            Item item = new Item();
            DataContext = item;
        }

        public void Clicked(object sender, MouseButtonEventArgs e)
        {
            Item i = DataContext as Item;
            var main = App.Current.MainWindow as MainWindow;
            main.addToGrid(i);
        }
    }
}
