﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void sayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }

    }
}
