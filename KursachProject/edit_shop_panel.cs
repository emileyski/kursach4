using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachProject.Controller;
using KursachProject.Model;

namespace KursachProject
{
    public partial class edit_shop_panel : Form
    {
        private Shop shop;
        private List<Tuple<int, Product>> current_product_list;
        private string password;

        internal edit_shop_panel(Shop shop,string password)
        {
            InitializeComponent();
            this.shop = shop;
            current_product_list_dg.AllowUserToAddRows = false;

            //присваиваем значения текст-боксам
            shop_name_tb.Text = shop.shop_name;
            city_tb.Text = shop.adress.city;
            street_tb.Text = shop.adress.street;
            number_tb.Text = shop.adress.number.ToString();

            cbStartTimeHour.Text = "год.";
            cbStartTimeMinute.Text = "хв.";
            cbEndTimeHour.Text = "год.";
            cbEndTimeMinute.Text = "хв.";

            shop_spec_tb.Text = shop.shop_specialization;

            phone_number_box.Text = shop.phone_number;

            for (int i = 0; i < shop.products.Count; i++)
            {
                Product product = shop.products[i].Item2;
                current_product_list_dg.Rows.Add(product.product_name,
                    shop.products[i].Item1,
                    product.product_price,
                    product.date_of_manufacture.ToString(),
                    product.expiration_date,
                    product.time_to_spoil());

            }
            MessageBox.Show(shop.shop_Id.ToString());

            current_product_list = shop.products;

            this.password = password;
        }

        private void is_ready_btn_Click(object sender, EventArgs e)
        {
            string shop_spec = "Не вибрано";
            if (shop_spec_cb.Text.Length > 0 || shop_spec_tb.Text.Length > 0)
            {
                shop_spec = (shop_spec_tb.Text.Length > 0) ? shop_spec_tb.Text : shop_spec_cb.Text;
            }
            Shop newShop = new Shop(shop.shop_Id, shop_name_tb.Text, shop_spec, phone_number_box.Text,
                            new Time(int.Parse(cbStartTimeHour.Text), int.Parse(cbStartTimeMinute.Text)), new Time(int.Parse(cbEndTimeHour.Text), int.Parse(cbEndTimeMinute.Text)),
                            new Adress(city_tb.Text, street_tb.Text, int.Parse(number_tb.Text)), current_product_list, password);
            Serializator.rewrite_shop(newShop);
            Close();
        }

        private void delete_product_from_list_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
