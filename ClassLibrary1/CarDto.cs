using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class CarDto
    {
        public CarDto(int brandId, string model)
        {
            BrandId = brandId;
            Model = model;
        }

        public string Model { get; }

        public int BrandId { get; }        
    }
}
