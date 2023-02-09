using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();


            Product pr1 = new Product();
            pr1.Price = 10;
            pr1.Price = -100;
            pr1.Name = "Coca cola 1L";
            pr1.Name = null;

            store.AddProduct(pr1);
            store.AddProduct(new Product { Name = "Pepsi cola 1L", Price = 30 ,DiscountPercent=10});
            store.AddProduct(new Product { Name = "Sprite 1", Price = 10 });
            store.AddProduct(new Product { Name = "Sprite 2", Price = 40,DiscountPercent=20 });
            store.AddProduct(new Product { Name = "Sprite 3", Price = 20 });
            store.AddProduct(new Product { Name = "Sprite 4", Price = 50,DiscountPercent=50 });


            var products = store.GetDiscountedProducts();
            products = store.GetProductsByPriceRange(20, 40);


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name+" - " + products[i].Price);
            }

        }
    }
}
