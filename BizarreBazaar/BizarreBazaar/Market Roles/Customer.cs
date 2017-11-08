using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    class Customer {
        private string customerName;

        private Customer()
        {
            this.customerName = "";
        }

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        public string GetName()
        {
            return customerName;
        }

        public void SetName(string customerName)
        {
            this.customerName = customerName;
        }
    }
}
