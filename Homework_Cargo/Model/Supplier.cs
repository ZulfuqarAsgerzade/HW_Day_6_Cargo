using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cargo.Model
{
    public class Supplier
    {
        public string name { get; set; }
        public string surname { get; set; }
        public List<Order> Orders { get; set; }

        public Supplier()
        {
            this.Orders= new List<Order>();
        }

        public Supplier(string name, string surname): this()
        {
            this.name = name;
            this.surname = surname;
        }

        public void addOrder(Order order)
        {
            this.Orders.Add(order);
        }

    }
}
