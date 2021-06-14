using AutoSparePartsE_shop.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSparePartsE_shop.Pages
{
    public class ProductsBase: ComponentBase
    {
        public IEnumerable<Product> Products  { get; set; }
        protected override Task OnInitializedAsync()
        {
            LoadProducts();
            return base.OnInitializedAsync();
        }

        private void LoadProducts()
        {
            Product p1 = new Product
            {
                ProductID = 1,
                ProductName = "Head Light",
                ProductCategory = "Body Parts",
                AvailablePsc = 2,
                AvailableOn = DateTime.Today,
                ProductPrice = 99.99,
                ImagePath ="images/1.jpg"
            };
            Product p2 = new Product
            {
                ProductID = 2,
                ProductName = "Front Fender",
                ProductCategory = "Body Parts",
                AvailablePsc = 1,
                AvailableOn = DateTime.Today,
                ProductPrice = 129.99,
                ImagePath = "images/2.jpg"
            };
            Product p3 = new Product
            {
                ProductID = 3,
                ProductName = "Motor Oil 5w40",
                ProductCategory = "Filters and Oils",
                AvailablePsc = 12,
                AvailableOn = DateTime.Today,
                ProductPrice = 19.99,
                ImagePath = "images/3.jpg"
            };
            Product p4 = new Product
            {
                ProductID = 4,
                ProductName = "Oil Filter",
                ProductCategory = "Filters and Oils",
                AvailablePsc = 6,
                AvailableOn = DateTime.Today,
                ProductPrice = 9.99,
                ImagePath = "images/4.jpg"
            };
            Product p5 = new Product
            {
                ProductID = 5,
                ProductName = "Brake Disks",
                ProductCategory = "Brake System",
                AvailablePsc = 0,
                AvailableOn = DateTime.Today.AddDays(2),
                ProductPrice = 89.99,
                ImagePath = "images/5.jpg"
            };
            Product p6 = new Product
            {
                ProductID = 6,
                ProductName = "Brake Pads",
                ProductCategory = "Brake System",
                AvailablePsc = 0,
                AvailableOn = DateTime.Today.AddDays(2),
                ProductPrice = 45.99,
                ImagePath = "images/6.jpg"
            };
            Products = new List<Product> { p1, p2, p3, p4, p5, p6 };
        }
    }
}
