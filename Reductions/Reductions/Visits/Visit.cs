using Reductions.Customers;
using Reductions.ServiceProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reductions.Visits
{
  public  class Visit
    {
        private readonly Dictionary<Customer, ServiceProduct> keyValuePairs;
        public Visit()
        {
           
            this.keyValuePairs = new Dictionary<Customer, ServiceProduct>();
        }

        public void AddServiceProduct(Customer customer, ServiceProduct serviceProduct)
        {
            if (this.keyValuePairs.Values.Contains(serviceProduct))
            {
                throw new InvalidOperationException($"ServiceProduct {serviceProduct} already exist!");
            }
            this.keyValuePairs.Add(customer, serviceProduct);
        }

        public decimal GetTotalPrice()
        {
          return  this.keyValuePairs.Values.Count();
           
        }
        public  void PrintInvoice()
        {
            Console.Write(this.keyValuePairs + " ");
        }
    
    }
}
