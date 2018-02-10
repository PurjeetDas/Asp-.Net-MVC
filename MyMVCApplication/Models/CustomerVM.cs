using System;
namespace MyMVCApplication.Models
{
    public class CustomerVM
    {
        public CustomerVM(string name, string address, string mobileno, DateTime orderdate, decimal orderprice)
        {
            this.Name = name;
            this.Address = address;
            this.Mobileno = mobileno;
            this.OrderDate = orderdate;
            this.OrderPrice = orderprice;
            
        }

        public CustomerVM()
        {
          

        }

        public int CustomerID { get; set; }
        public string Name { get; set; } // Customer
        public string Address { get; set; } // Customer
        public string Mobileno { get; set; } // Customer
        public Nullable<System.DateTime> OrderDate { get; set; } // Order
        public Nullable<decimal> OrderPrice { get; set; } // Order
    }
}
