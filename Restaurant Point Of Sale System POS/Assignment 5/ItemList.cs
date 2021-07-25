using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class ItemList
    {
        public static List<Item> IList = new List<Item>();
        public static void initialize()
        {
            string image_path = @"..\images\";

            IList.Add(new Item { title = "Zinger Burger", price = 200, quantity = 100, tax = false, barcode = 101, type ="Burger", image = (image_path + "Zinger.png")});
            IList.Add(new Item { title = "Grill Burger", price = 300, quantity = 80, tax = true, barcode = 102, type = "Burger", image = (image_path + "Grill.png") });
            IList.Add(new Item { title = "Cheese Burger", price = 250, quantity = 80, tax = false, barcode = 103, type = "Burger", image = (image_path + "Cheese.png") });
            IList.Add(new Item { title = "Fajita Pizza", price = 800, quantity = 100, tax = true, barcode = 104, type = "Pizza", image = (image_path + "Fajita.png") });
            IList.Add(new Item { title = "Chicken Pizza", price = 850, quantity = 50, tax = true, barcode = 105, type = "Pizza", image = (image_path + "Chicken-Tikka.png") });
            IList.Add(new Item { title = "Vegetable Pizza", price = 700, quantity = 50, tax = true, barcode = 106, type = "Pizza", image = (image_path + "Vegetable.png") });
            IList.Add(new Item { title = "Pepperoni Pizza", price = 800, quantity = 50, tax = true, barcode = 107, type = "Pizza", image = (image_path + "pepperoni.png") });
            IList.Add(new Item { title = "CokaCola", price = 50, quantity = 200, tax = false, barcode = 108, type = "SoftDrink", image = (image_path + "cokacola.png") });
            IList.Add(new Item { title = "Sprite", price = 50, quantity = 150, tax = false, barcode = 109, type = "SoftDrink", image = (image_path + "sprite.jpeg") });
            IList.Add(new Item { title = "Apple", price = 100, quantity = 100, tax = true, barcode = 110, type = "Fruit", image = (image_path + "apple.jpg") });
            IList.Add(new Item { title = "Banana", price = 80, quantity = 120, tax = false, barcode = 111, type = "Fruit", image = (image_path + "banana.png") });
            IList.Add(new Item { title = "Mango", price = 200, quantity = 50, tax = true, barcode = 112, type = "Fruit", image = (image_path + "mango.png") });
            IList.Add(new Item { title = "Vanilla Icecream", price = 200, quantity = 30, tax = true, barcode = 113, type = "Icecream", image = (image_path + "Vanilla.png") });
            IList.Add(new Item { title = "Choclate Icecream", price = 220, quantity = 30, tax = true, barcode = 114, type = "Icecream", image = (image_path + "Chocolate.png") });
            IList.Add(new Item { title = "Mango Icecream", price = 230, quantity = 30, tax = true, barcode = 115, type = "Icecream", image = (image_path + "Mango.jpg") });
            IList.Add(new Item { title = "Plain Tea", price = 30, quantity = 200, tax = false, barcode = 116, type = "Tea", image = (image_path + "tea.png") });
            IList.Add(new Item { title = "Caramel Coffee", price = 150, quantity = 50, tax = true, barcode = 117, type = "Coffee", image = (image_path + "Caramel.jpg") });
            IList.Add(new Item { title = "Cappuccino", price = 200, quantity = 50, tax = true, barcode = 118, type = "Coffee", image = (image_path + "Cappuccino.png") });
            IList.Add(new Item { title = "Gold Leaf", price = 100, quantity = 100, tax = true, barcode = 119, type = "Cigarette", image = (image_path + "cigarette.png") });
            IList.Add(new Item { title = "Apple Juice", price = 80, quantity = 80, tax = true, barcode = 120, type = "Juice", image = (image_path + "apple-juice.png") });
        }       
    }
}
