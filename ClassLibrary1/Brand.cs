using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Brand
    {
        public Brand(string name, Car[] cars)
        {
            Name = name;
            Cars = cars;
        }

        public string Name { get; }

        public Car[] Cars { get; }
    }
}
