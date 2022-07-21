using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachProject.Model
{
    internal class Shop
    {
        public string shop_name;
        public Adress adress;
        //список кортежей с количеством продуктов и описанием продукта
        public List<Tuple<int, Product>> products;
    }
    public struct Adress
    {
        public string city;
        public string street;
        public int number;
    }
}
