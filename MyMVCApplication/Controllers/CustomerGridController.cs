using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using MyMVCApplication.Models;
                      
namespace MyMVCApplication.Controllers
{
    public class CusomterGridController: Controller
    {
        private CustomerService CustomerService;

        public CusomterGridController()
        {
            CustomerService = new CustomerService();
        }

        protected override void Dispose(bool disposing)
        {
            //CustomerService.Dispose();

            base.Dispose(disposing);
        }

        //[Demo]
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Customers_Read([DataSourceRequest]DataSourceRequest request)
        {

            List<CustomerVM> CustomerOrderList = GetCustomers();
            DataSourceResult result = new DataSourceResult();
            result.Data = CustomerOrderList;
            result.Total = CustomerOrderList.Count;
            return this.Json(result);
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers_Create([DataSourceRequest] DataSourceRequest request, CustomerVM customer)
        {

            return Json(new[] { customer }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers_Update([DataSourceRequest] DataSourceRequest request, CustomerVM customer)
        {
           
            return Json(new[] { customer }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers_Destroy([DataSourceRequest] DataSourceRequest request, CustomerVM customer)
        {
           

            return Json(new[] { customer }.ToDataSourceResult(request, ModelState));
        }

        private static List<CustomerVM> GetCustomers()
        {
            List<CustomerVM> CustomerOrderList = new List<CustomerVM>();
            try{


                CustomerOrderList.Add(new CustomerVM("Alex", "Reston,VA", "2345673425", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Ryan", "Reston,VA", "2345674535", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Max", "Reston,VA", "2345673790", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Sam", "Reston,VA", "23456757694", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Rose", "Reston,VA", "2345667544", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Will", "Reston,VA", "2345678890", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("John", "Reston,VA", "2345672313", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Liza", "Reston,VA", "2345670955", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Ron", "Reston,VA", "2345678754", new DateTime(2018, 02, 10), 50.0M));
                CustomerOrderList.Add(new CustomerVM("Jack", "Reston,VA", "2345670000", new DateTime(2018, 02, 10), 50.0M));
            }catch(Exception ex){
                Console.WriteLine(ex);
            }


            return CustomerOrderList;
        }


    }
}
