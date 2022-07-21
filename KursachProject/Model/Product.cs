using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachProject.Model
{
    internal class Product
    {
        public string product_name;
        public string product_description;

        //поле, необходимое для идентификации магазина, в котором находиться товар
        public int shop_id;

        public float product_price;
        public Date date_of_manufacture;

        //срок годности выраженый в днях
        public int expiration_date;


        //public Product(string product_name, string product_description, string shop_name, int product_price)
        //{
        //    this.product_name = product_name;
        //    this.product_description = product_description;
        //    this.shop_name = shop_name;
        //    this.product_price = product_price;
        //}
        public Product(string product_name, string product_description, float product_price, int expiration_date)
        {
            this.product_name = product_name;
            this.product_description = product_description;
            this.product_price = product_price;
            this.expiration_date = expiration_date;
        }
    }
    public struct Date
    {
        public int year;
        public int month;
        public int day;
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }
}
