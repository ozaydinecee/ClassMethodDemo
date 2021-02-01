using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "ece";
            customer1.CustomerLastName = "ozaydin";


            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "yildiz";
            customer2.CustomerLastName = "ozaydin";


            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "elif";
            customer3.CustomerLastName = "ozaydin";




            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.CustomerAdd(customer1);
            customerManager1.CustomerAdd(customer2);
            customerManager1.CustomerAdd(customer3);

            Console.WriteLine("-----Customer List--------"); 

            List<Customer> listCustomer = new List<Customer> { customer1, customer2, customer3 };
            customerManager1.CustomerList(listCustomer);

            Console.ReadLine();
        }
    }
}
