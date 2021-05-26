using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductModel> _products = new List<ProductModel>
        {
            new ProductModel(){Id = 1 , Name = "Black Coffee" , Price = 10.0 , img = "https://images.pexels.com/photos/1405761/pexels-photo-1405761.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
            new ProductModel(){Id = 2 , Name = "Tea" , Price = 3.0 , img = "https://images.pexels.com/photos/539432/pexels-photo-539432.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
            new ProductModel(){Id = 3 , Name = "Espresso" , Price = 13.0, img ="https://images.pexels.com/photos/272887/pexels-photo-272887.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500" }
        }; 
        // GET
        public IActionResult Index( String color = "" )
        {
            ViewData["Products"] = _products;
            ViewData["tcolor"] = color;
            return View();
        }
        public IActionResult Details(int? id )
        {
            
            ViewData["Product"] = _products.Find(model => model.Id == id);
            
            return View();
        }
    }
}