﻿using System;
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
        //метод, необходимый для записи в шаблон продуктов нового
        public static void add_product_to_sample(Product product)
        {
            const string filePath = "product_sample_list.json";
            if (File.Exists(filePath))
            {
                List<Product> SampleList = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(filePath));
                SampleList.Add(product);
                File.WriteAllText(filePath,JsonConvert.SerializeObject(SampleList));
            }
            else
            {
                List<Product> SampleList = new List<Product>() { product};
                File.WriteAllText(filePath, JsonConvert.SerializeObject(SampleList));
            }
        }
        //метод, необходимый для записи нового магазина в список
        public static void add_shop_to_list(Shop shop)
        {
            const string filePath = "shop_list.json";
            if (File.Exists(filePath))
            {
                List<Shop> shopList = JsonConvert.DeserializeObject<List<Shop>>(File.ReadAllText(filePath));
                shopList.Add(shop);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(shopList));
            }
            else
            {
                List<Shop> shopList = new List<Shop>() { shop };
                File.WriteAllText(filePath, JsonConvert.SerializeObject(shopList));
            }
        }
    }
}