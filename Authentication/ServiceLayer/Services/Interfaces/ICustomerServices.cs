using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerServices
    {
        int GetCustomerCountByFiltered();

        Customer[] GetCustomersByfiltered(int startAge , int endAge);
        double GetCustomersAvaragebyAge();
    }
}
