using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Model.AccountName
{
    class AccountNameDetail
    {
        public long AccountNameID { get; set; }
        public Vendor_Customer AccountNameType { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
