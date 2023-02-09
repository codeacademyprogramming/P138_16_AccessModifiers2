using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    public class Store
    {
        public Product[] Products = new Product[0]; 

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }


        //GetDiscountedProducts() - endirimli mehsullarin siyahisini qaytarir

        public Product[] GetDiscountedProducts()
        {
            Product[] wantedProducts = new Product[0];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].DiscountPercent > 0)
                {
                    Array.Resize(ref wantedProducts, wantedProducts.Length + 1);
                    wantedProducts[wantedProducts.Length-1]= Products[i];
                }
            }


            return wantedProducts;
        }

        //GetProductsByPriceRange(min,max)
        //Verilmis qiymet intervalina gore price deyeri hemin araliqda olan
        //mehsullardan ibaret siyahi qaytaran metod

        public Product[] GetProductsByPriceRange(double minPrice,double maxPrice)
        {
            Product[] wantedProducts = new Product[0];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Price>=minPrice && Products[i].Price<=maxPrice)
                {
                    Array.Resize(ref wantedProducts, wantedProducts.Length + 1);
                    wantedProducts[wantedProducts.Length - 1] = Products[i];
                }
            }

            return wantedProducts;
        }

    }
}
