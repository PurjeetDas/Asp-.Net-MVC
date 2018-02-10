using System;
namespace MyMVCApplication.Models
{
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> OrderPrice { get; set; }
    }
}
