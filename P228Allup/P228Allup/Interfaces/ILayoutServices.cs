using P228Allup.Models;
using P228Allup.ViewModels.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Allup.Interfaces
{
    public interface ILayoutServices
    {
        Task<Dictionary<string, string>> GetSettingAsync();
        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<IEnumerable<BasketVM>> GetBaskteAsync(); 

    }
}
