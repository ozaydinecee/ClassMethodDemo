using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Customer added: "+customer.CustomerName+" " + customer.CustomerLastName+ "  Id:"+customer.CustomerId);
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Customer deleted:" + customer.CustomerName + " " + customer.CustomerLastName + "Id:" + customer.CustomerId);
        }
        public void CustomerList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastName);
            }
        }

    }
}
