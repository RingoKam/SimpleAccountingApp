using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp_Model
{
    public class Customer
    {
        int CustomerInt { get; set; }
        string Address { get; set; }
        DateTime DateCreated { get; set; }
        string Name { get; set; }
        int Phone { get; set; }
        bool IsCustomer { get; set; }
    }
}
