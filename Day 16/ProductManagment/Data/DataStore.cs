using ProductManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagment.Data
{
    internal class DataStore
    {
        public static List<Category> Categories;
        public static List<Product> Products;

        static DataStore()
        {
            Categories = new List<Category>()
            {
                new Category{Id=1, Name="Uncategorized"}
            };

            Products = new List<Product>()
            {
                new Product{Id=1,Name="Product 1", CategoryId=1},
                new Product{Id=2,Name="Product 2", CategoryId=1}
            };
        }
    }
}
