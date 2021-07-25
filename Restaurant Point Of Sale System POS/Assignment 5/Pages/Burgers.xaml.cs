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
    /// Interaction logic for Burgers.xaml
    /// </summary>
    public partial class Burgers : Page
    {
        public Burgers()
        {
            InitializeComponent();
        
            one.DataContext = ItemList.IList[0];
            two.DataContext = ItemList.IList[1];
            three.DataContext = ItemList.IList[2];
  
        }
    }
}
