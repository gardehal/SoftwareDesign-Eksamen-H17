namespace BizarreBazaar {
    public class Customer {
        public string customerName { get; set; }

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
