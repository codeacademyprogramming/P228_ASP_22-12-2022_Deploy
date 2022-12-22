using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstAPI.DTOs.CategoryDTOs
{
    public class CategoryForDetailDto
    {
        public int CategoryKey { get; set; }
        public string Ad { get; set; }
        public string KimYarad { get; set; }
        public string ImagePath { get; set; }
    }
}
