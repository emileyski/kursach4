using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KursachProject.Model;
using System.IO;

namespace KursachProject.Controller
{
    internal static class Serializator
    {
        const string product_sample_list = "product_sample_list.json";
        const string shop_list = "shop_list.json";

        //метод, необходимый для записи в шаблон продуктов нового
        public static void add_product_to_sample(Product product)
        {
            List<Product> SampleList = get_product_sample_list(); SampleList.Add(product);
            write_product_sample_list(SampleList);
        }
        //метод, который записывает все продукты
        public static void write_product_sample_list(List<Product> products)
        {
            File.WriteAllText(product_sample_list, JsonConvert.SerializeObject(products));
        }
        //метод, необходимый для записи нового магазина в список
        public static void add_shop_to_list(Shop shop)
        {
            List<Shop> shopList = get_shop_list();
            shopList.Add(shop);
            write_all_shops(shopList);
        }
        //метод, возвращающий список зарегистрированных магазинов
        public static List<Shop> get_shop_list()
        {
            if(File.Exists(shop_list)) return JsonConvert.DeserializeObject<List<Shop>>(File.ReadAllText(shop_list));
            else return new List<Shop>();
        }
        //метод, возвращающий шаблон продуктов, созданый ранее
        public static List<Product> get_product_sample_list()
        {
            if (File.Exists(product_sample_list)) return JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(product_sample_list));
            else return new List<Product>();
        }
        //метод, удаляющий шаблон продукта из списка
        public static void delete_product_sample_from_list(int sampleIndex)
        {
            List<Product> products = get_product_sample_list();
            products.RemoveAt(sampleIndex);
            write_product_sample_list(products);
        }
        //метод, который записывает все магазины в формат json
        public static void write_all_shops(List<Shop> shopList)
        {
            File.WriteAllText(shop_list, JsonConvert.SerializeObject(shopList));
        }
        public static void delete_shop_at_index(int index)
        {
            List<Shop> shop_list = get_shop_list();
            shop_list.RemoveAt(index);
            write_all_shops(shop_list);
        }
    }
}
