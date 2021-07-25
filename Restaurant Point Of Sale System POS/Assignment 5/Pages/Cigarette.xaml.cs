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
    /// Interaction logic for Cigarette.xaml
    /// </summary>
    public partial class Cigarette : Page
    {
        public Cigarette()
        {
            InitializeComponent();
            ninteen.DataContext = ItemList.IList[18];
        }
    }
}
