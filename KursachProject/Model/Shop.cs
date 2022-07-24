using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachProject.Controller;

namespace KursachProject.Model
{
    internal class Shop
    {
        public int shop_Id;
        public string shop_name;
        public string shop_specialization;
        public Adress adress;
        public string phone_number;
        public Time open_time, close_time;
        //список кортежей с количеством продуктов и описанием продукта
        public List<Tuple<int, Product>> products;

        public string password;

        public Shop(int shop_Id, string shop_name, string shop_specialization, string phone_number, Time open_time,Time close_time, Adress adress, List<Tuple<int, Product>> products, string password)
        {
            this.shop_Id = shop_Id;
            this.shop_name = shop_name;
            this.adress = adress;
            this.shop_specialization = shop_specialization;
            this.products = products;
            this.phone_number = phone_number;
            this.open_time = open_time;
            this.close_time = close_time;
            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i].Item2;
                product.shop_id = this.shop_Id;
                products[i] = Tuple.Create(products[i].Item1, product);
            }

            this.password = password;
        }
        public bool give_access(string pass)
        {
            if (Serializator.getHash(pass) == password) return true;
            else return false;
        }
        public bool set_new_password(string pass, string new_pass)
        {
            //if (Serializator.getHash(pass) == password)
            //{
            //    MessageBox.Show("gththtr");
            //}
            if (Serializator.getHash(pass) == password)
            {
                password = Serializator.getHash(new_pass);
                return true;
            }
            else return false;
        }
        public override bool Equals(object obj)
        {
            try
            {
                Shop shop = (Shop)obj;
                if (shop_name == shop.shop_name
                    && shop_Id == shop.shop_Id
                    && shop_specialization == shop.shop_specialization
                    && adress.Equals(shop.adress)
                    && phone_number == shop.phone_number
                    && open_time.Equals(shop.open_time) && close_time.Equals(shop.close_time)
                    && products == shop.products
                    && password == shop.password)
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
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
        public override string ToString()
        {
            return "м. " + city + ", вул. " + street + ", буд. " + number;
        }
    }
    public struct Time
    {
        public int hour;
        public int minute;
        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
        public override string ToString()
        {
            string time = (hour < 10) ? "0" + hour : hour.ToString();
            time += ":";
            time += (minute < 10) ? "0" + minute : minute.ToString();
            return time;
        }
    }

}
