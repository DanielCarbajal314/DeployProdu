using System;
using System.Collections.Generic;
using System.Text;

namespace DevOpsData
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>() {
                new Product() { Id = 1, Name = "Apple" },
                new Product() { Id = 2, Name = "Orange"}
            };
        }
    }
}
