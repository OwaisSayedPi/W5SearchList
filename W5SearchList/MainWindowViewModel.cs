using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace W5SearchList
{
    public class MainWindowViewModel : BaseViewModel
    {
        public SearchableViewModel SearchList1 { get; set; }
        public SearchableViewModel SearchList2 { get; set; }
        public SearchableViewModel SearchList3 { get; set; }
        public List<Product> ProductList { get; set; }
        public List<Order> OrderList { get; set; }
        public MainWindowViewModel()
        {
            ProductList = new List<Product>() {
                new Product() { ProductID = 1, ProductName = "Milkshake"},
                new Product() { ProductID = 2, ProductName = "Apple Juice"},
                new Product() { ProductID = 3, ProductName = "Mocktail"},
                new Product() { ProductID = 4, ProductName = "Cocktail"},
                new Product() { ProductID = 5, ProductName = "On the Rocks"},
            };
            OrderList = new List<Order>()
            {
                new Order() { OrderID = 1001, Location = "Mumbai"},
                new Order() { OrderID = 1002, Location = "Alibaug"},
                new Order() { OrderID = 1003, Location = "Pune"},
                new Order() { OrderID = 1004, Location = "Konkan"},
                new Order() { OrderID = 1005, Location = "Lonavla"},
            };
            List<string> friends = new List<string>()
            {
                "Owais", "Amey", "Ajay", "Sagar"
            };
            SearchList1 = new SearchableViewModel<Product>(ProductList);
            SearchList2 = new SearchableViewModel<string>(friends);
            SearchList3 = new SearchableViewModel<Order>(OrderList);
        }        
    }
}
