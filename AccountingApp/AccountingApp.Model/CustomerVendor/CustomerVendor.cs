using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Model.CustomerVendor
{
    class CustomerVendor
    {
        public long CustomerVendorID { get; set; }
        public Vendor_Customer CustomerVendorType { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
