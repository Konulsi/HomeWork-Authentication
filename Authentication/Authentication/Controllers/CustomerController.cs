using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class CustomerController 
    {
        private readonly ICustomerServices _service;
        
        public CustomerController()
        {
            _service = new Customerservice();
        }

        public void GetCustomerCountByFiltered()
        {
            Console.WriteLine(_service.GetCustomerCountByFiltered());
        }


        public void GetCustomersAvaragebyAge()
        {
            Console.WriteLine(_service.GetCustomersAvaragebyAge());
        }


        public void GetCustomersByFiltered()
        {
            int startAge = 22;
            int endAge = 30;
            Customer[] result = _service.GetCustomersByfiltered(startAge, endAge);
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Position}  {item.Age}");
                }
            }

        }
    }
}
