using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cargo.Model
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public int count { get; set; }

        public Product(string name, Category category, int count)
        {
            Name = name;
            Category = category;
            this.count = count;
        }
    }
}
