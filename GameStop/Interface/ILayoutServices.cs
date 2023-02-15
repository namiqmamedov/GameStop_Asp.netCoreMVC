using GameStop.Models;
using GameStop.ViewModels.Basket;
using GameStop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Interface
{
    public interface ILayoutServices
    {
        Task<Dictionary<string, string>> GetSettingsAsync();
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<IEnumerable<SubCategory>> GetSubCategoriesAsync();
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<List<BasketVM>> GetBasket();
    }
}
