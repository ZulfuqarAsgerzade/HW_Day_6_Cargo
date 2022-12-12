using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cargo.Model
{
    public class Order
    {
        public Client Client { get; set; }
        public Worker Worker { get; set; }
        public List<Product> Products { get; set; }

        public Order()
        {
            this.Products = new List<Product>();
        }

        public Order(Client client) : this()
        {
            Client = client;
        }

        public void addProduct(Product product)
        {
            this.Products.Add(product);
        }
    }
}
