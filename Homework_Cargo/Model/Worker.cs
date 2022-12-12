using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cargo.Model
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Order> Orders { get; set; }

        public Worker()
        {
            this.Orders = new List<Order>();
        }


        public Worker(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
        }

        public void addOrder(Order order)
        { 
            this.Orders.Add(order);
        }
    }
}
