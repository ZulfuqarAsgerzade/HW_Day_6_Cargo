﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cargo.Model
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }
}
