using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BrandDto
    {
        public BrandDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; }

        public int Id { get; }
    }
}
