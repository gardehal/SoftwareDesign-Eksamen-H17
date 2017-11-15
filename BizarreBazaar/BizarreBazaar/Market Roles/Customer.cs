using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    class Customer {
        public string customerName { get; set; }
        public int itemCount { get; set; }

        private Customer()
        {
            this.customerName = "";
        }

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }
    }
}
