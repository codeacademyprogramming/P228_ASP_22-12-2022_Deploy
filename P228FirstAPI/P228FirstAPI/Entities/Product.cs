using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstAPI.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
