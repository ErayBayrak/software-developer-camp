﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductDetailTest();
        }

        private static void ProductDetailTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var p in categoryManager.GetAll())
            {
                Console.WriteLine(p.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetByUnitPrice(0, 50);
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("{0} ---- {1}", product.ProductName, product.UnitPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }


    }
}
