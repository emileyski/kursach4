using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachProject.Model
{
    internal class Shop
    {
        public int shop_Id;
        public string shop_name;
        public string shop_specialization;
        public Adress adress;
        //список кортежей с количеством продуктов и описанием продукта
        public List<Tuple<int, Product>> products;

        public Shop(int shop_Id, string shop_name, string shop_specialization, Adress adress, List<Tuple<int, Product>> products)
        {
            this.shop_Id = shop_Id;
            this.shop_name = shop_name;
            this.adress = adress;
            this.shop_specialization = shop_specialization;
            this.products = products;
            for(int i = 0; i < products.Count; i++)
            {
                Product product = products[i].Item2;
                product.shop_id = this.shop_Id;
                products[i] = Tuple.Create(products[i].Item1, product);
            }
        }
    }
    public struct Adress
    {
        public string city;
        public string street;
        public int number;
        public Adress(string city, string street, int number)
        {
            this.city = city;
            this.street = street;
            this.number = number;
        }
    }
}
