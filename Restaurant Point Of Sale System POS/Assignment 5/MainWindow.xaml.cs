using System;
using System.Collections.Generic;
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
using System.Windows.Threading;
using Assignment_5.Pages;
using System.Data;
using Assignment_5.Database;

namespace Assignment_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            f1.Content = new All();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            barcode.IsEnabled = false;
            ItemTypeSearch.IsEnabled = false;
        }

        private void barClear(object sender, RoutedEventArgs e)
        {
            barcode.Clear();
        }

        private void ItemTypeClear(object sender, RoutedEventArgs e)
        {
            ItemTypeSearch.Clear();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            datetime.Content = DateTime.Now.ToString("dddd, MMM dd yyyy hh:mm:ss");
        }

        double tax = 0;
        double total_amount = 0;

        public bool addToGrid(Item item)
        {
            try
            {
                if (item != null)
                {
                    Order ord = new Order(item);
                    // if (!IfExists(ord))
                    {
                        dg.Items.Add(ord);

                        tax += ord.tax * (0.05 * ord.total);
                        total_amount += ord.total;
                        T3.Content = tax.ToString();
                        T1.Content = total_amount.ToString();
                        T4.Content = (total_amount + tax).ToString();
                    }
                    ItemList.IList[ItemList.IList.IndexOf(item)].quantity--;
                    f1.Refresh();

                    return true;
                }
            }
            catch(Exception e)
            { }
            return false;
        }

        private bool IfExists(Order ord)
        {
            foreach(Order o in dg.Items)
            {
                if (ord.title.Equals(o.title))
                {
                    o.quantity += 1;
                    o.calTotal();

                    return true;
                }
            }
            return false;
        }

        private void cleanAll(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void clear()
        {
            while (dg.Items.Count > 0)
            {
                dg.Items.RemoveAt(0);
            }
            T1.Content = "00.00";
            T2.Content = "00.00";
            T3.Content = "00.00";
            T4.Content = "00.00";
            T5.Content = "00.00";
        }

        private void Softdrink(object sender, RoutedEventArgs e)
        {
            f1.Content = new SoftDrink();
        }

        private void Pizza(object sender, RoutedEventArgs e)
        {
            f1.Content = new Pizza();
        }

        private void Burger(object sender, RoutedEventArgs e)
        {
            f1.Content = new Burgers();
        }

        private void All(object sender, RoutedEventArgs e)
        {
            f1.Content = new All();
        }

        private void Fruit(object sender, RoutedEventArgs e)
        {
            f1.Content = new Fruit();
        }

        private void Coffee(object sender, RoutedEventArgs e)
        {
            f1.Content = new Coffee();
        }

        private void Tea(object sender, RoutedEventArgs e)
        {
            f1.Content = new Tea();
        }

        private void Icecream(object sender, RoutedEventArgs e)
        {
            f1.Content = new Icecream();
        }

        private void Juice(object sender, RoutedEventArgs e)
        {
            f1.Content = new Juice();
        }

        private void Cigarette(object sender, RoutedEventArgs e)
        {
            f1.Content = new Cigarette();
        }

        private void check(object sender, KeyEventArgs e)
        {
            
        }

        private void Payment(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Order> OL = new List<Order>();

                foreach (Order o in dg.Items)
                {
                    OL.Add(o);
                }

                DB.Insert(total_amount + tax, OL);
                Pdf.createPDF(OL, total_amount,tax);

                MessageBox.Show("Thanks for shopping,\nThe Receipt is generated and stored as pdf in Receipts folder, visible on right side","Success", MessageBoxButton.OK, MessageBoxImage.Information);
                clear();
            }
            catch(Exception)
            {
                MessageBox.Show("An exception occurred","Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteRow(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem != null)
            {
                Order ord = dg.SelectedItem as Order;
                total_amount -= ord.total;
                tax -= ord.tax * (0.05 * ord.total);

                T3.Content = tax.ToString();
                T1.Content = total_amount.ToString();
                T4.Content = (total_amount + tax).ToString();

                dg.Items.Remove(dg.SelectedItem);
                f1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Error");
            }
        }
    }
}
