using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachProject.Model
{
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
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
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

        public Product(string product_name, string product_description, float product_price, int expiration_date)
        {
            this.product_name = product_name;
            this.product_description = product_description;
            this.product_price = product_price;
            this.expiration_date = expiration_date;
        }
        public Product() { }
        public override string ToString()
        {
            return product_name + ": " + product_price;
        }
        public int time_to_spoil()
        {
            DateTime dateTime = new DateTime(date_of_manufacture.year, date_of_manufacture.month, date_of_manufacture.day);
            int time = (365 * DateTime.Now.Year + DateTime.Now.DayOfYear+ expiration_date) - (365 * dateTime.Year + dateTime.DayOfYear);
            return time;
        }
        public override bool Equals(object obj)
        {
            try
            {
                Product product = (Product)obj;
                if (product_name == product.product_name
                    && product_description == product.product_description
                    && shop_id == product.shop_id
                    && product_price == product.product_price
                    && date_of_manufacture.Equals(product.date_of_manufacture)
                    && expiration_date == product.expiration_date)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
    
}
