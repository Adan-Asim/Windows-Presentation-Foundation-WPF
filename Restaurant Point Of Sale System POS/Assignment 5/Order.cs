using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Assignment_5
{
    class Order:INotifyPropertyChanged
    {
        public string title { set; get; }
        public double price { set; get; }
        public int quantity { set; get; }
        public int tax { set; get; }
        public double total { set; get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string comments { set; get; }

        public Order(Item obj)
        {
            title = obj.title;
            price = obj.price;
            quantity = 1;

            if (obj.tax == true)
                tax = 1;
            else
                tax = 0;

            total = calTotal();
            comments = "";
        }
        
        public double calTotal()
        {
            return price * quantity;
        }
    }
}
