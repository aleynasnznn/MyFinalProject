using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace MyFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if(result.Success)
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CategoryName + " / " + product.CategoryName);
                }

            else
                Console.WriteLine(result.Message);
        }
    }
}
