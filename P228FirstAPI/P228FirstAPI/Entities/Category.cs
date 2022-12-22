using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstAPI.Entities
{
    public class Category :BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
