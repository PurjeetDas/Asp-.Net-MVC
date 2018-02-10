 using System;
namespace MyMVCApplication.Models
{
    public partial class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobileno { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string EmailID { get; set; }
    }

}

