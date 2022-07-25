using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KursachProject.Model;
using KursachProject.Controller;

namespace KursachProject.Controller
{
    internal static class InfoFinder
    {
       public static List<Tuple<int,Product>> get_products_by_city(List<Tuple<int, Product>> products,string city)
        {
            List<Tuple<int,Product>> res_products = new List<Tuple<int,Product>>();

            for(int i = 0;i < products.Count; i++)
            {
                if (products[i].Item2.get_parent_shop().adress.city == city)
                {
                    res_products.Add(products[i]);
                }
            }

            return res_products;
        }
        public static List<Tuple<int, Product>> get_products_by_shop_name(List<Tuple<int, Product>> products, string shop_name)
        {
            List<Tuple<int, Product>> res_products = new List<Tuple<int, Product>>();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Item2.get_parent_shop().shop_name.Contains(shop_name))
                {
                    res_products.Add(products[i]);
                }
            }

            return res_products;
        }

        public static List<Tuple<int, Product>> get_products_by_specialization(List<Tuple<int, Product>> products, string specialization)
        {
            List<Tuple<int, Product>> res_products = new List<Tuple<int, Product>>();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Item2.get_parent_shop().shop_specialization == specialization)
                {
                    res_products.Add(products[i]);
                }
            }

            return res_products;
        }
        public static List<Tuple<int, Product>> get_products_by_product_name(List<Tuple<int, Product>> products, string product_name)
        {
            List<Tuple<int, Product>> res_products = new List<Tuple<int, Product>>();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Item2.product_name.Contains( product_name))
                {
                    res_products.Add(products[i]);
                }
            }

            return res_products;
        }
        public static List<Tuple<int, Product>> get_products_by_min_count(List<Tuple<int, Product>> products, string min_count_)
        {
            List<Tuple<int, Product>> res_products = new List<Tuple<int, Product>>();

            int min_count = int.Parse(min_count_);

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Item1 >= min_count)
                {
                    res_products.Add(products[i]);
                }
            }

            return res_products;
        }
        public static List<Tuple<int, Product>> get_products_by_max_price(List<Tuple<int, Product>> products, string max_price)
        {
            List<Tuple<int, Product>> res_products = new List<Tuple<int, Product>>();

            try
            {
                int maxPrice = int.Parse(max_price);

                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Item2.product_price <= maxPrice)
                    {
                        res_products.Add(products[i]);
                    }
                }

                return res_products;
            }
            catch
            {
                return new List<Tuple<int, Product>>();
            }
        }
        public static List<Tuple<int, Product>> get_products_by_by_freshness(List<Tuple<int, Product>> products)
        {
            List<Tuple<int, Product>> res_products = new List<Tuple<int, Product>>();


            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Item2.time_to_spoil() > 0)
                {
                    res_products.Add(products[i]);
                }
            }

            return res_products;
        }
    }
}
