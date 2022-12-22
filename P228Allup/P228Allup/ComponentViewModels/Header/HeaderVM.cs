﻿using P228Allup.Models;
using P228Allup.ViewModels.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Allup.ComponentViewModels.Header
{
    public class HeaderVM
    {
        public Dictionary<string, string> Settings { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BasketVM> BasketVMs { get; set; }
    }
}
