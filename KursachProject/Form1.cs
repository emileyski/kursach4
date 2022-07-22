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
    public partial class Form1 : Form
    {
        //список продуктов и их колво, необходимый для редактирования здесь и сейчас
        List<Tuple<int, Product>> currentProductList;
        public Form1()
        {
            InitializeComponent();
            currentProductList = new List<Tuple<int, Product>>();
            make_first_tab();
            product_template_list_dg.AllowUserToAddRows = false;
            shop_list_dg.AllowUserToAddRows = false;
            current_product_list_dg.AllowUserToAddRows = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_product_to_sample_btn_Click(object sender, EventArgs e)
        {
            try {
                Serializator.add_product_to_sample(new Product(product_name_tb.Text,
                    product_description_tb.Text,
                    float.Parse(product_price_tb.Text),
                    int.Parse(expiration_date_tb.Text)));

                //чистим поля для ввода
                make_third_tab();
            }
            catch {
                MessageBox.Show("Одне або кілька полів було заповнено некоректно", "Увага", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void main_tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 0:
                    make_first_tab();
                    break;
                case 1:
                    make_second_tab();
                    break;
                case 2:
                    make_third_tab();
                    break;
            }
        }

        private void make_spec_list()
        {
            List<Shop> shops = Serializator.get_shop_list();
            for(int i = 0; i < shops.Count; i++)
            {
                if (!shop_spec_cb.Items.Contains(shops[i].shop_specialization))
                {
                    shop_spec_cb.Items.Add(shops[i].shop_specialization);
                }
            }
        }
        
        //метод, который подгружает данные для первой страницы
        private void make_first_tab()
        {
            product_sample_cb.Items.Clear();
            product_sample_cb.Text = null;
            List<Product> products = Serializator.get_product_sample_list();
            for (int i = 0; i < products.Count; i++)
            {
                product_sample_cb.Items.Add(products[i].ToString());
            }
            //вызываем метод, который отобразит список созданых ранее специализаций
            make_spec_list();
            shop_spec_tb.Clear();
            city_tb.Clear();
            current_product_list_dg.Rows.Clear();
            currentProductList.Clear();
            phone_number_box.Clear();
            shop_spec_cb.SelectedIndex = -1;
            shop_spec_cb.Text = null;
            shop_name_tb.Clear();
            street_tb.Clear();
            number_tb.Clear();
            product_count_tb.Clear();
            cbStartTimeHour.Text = "год.";
            cbStartTimeHour.Text = "хв.";
            cbEndTimeHour.Text = "год.";
            cbEndTimeMinute.Text = "хв.";
        }
        private void make_second_tab()
        {
            shop_list_dg.Rows.Clear();
            List<Shop> shopList = Serializator.get_shop_list();
            for(int i = 0; i < shopList.Count; i++)
            {
                shop_list_dg.Rows.Add(shopList[i].shop_name,
                    shopList[i].adress.ToString(),
                    shopList[i].products.Count,
                    shopList[i].open_time.ToString(),
                    shopList[i].close_time.ToString());
            }
            added_product_sample_cb.Items.Clear();
            List<Product> products = Serializator.get_product_sample_list();
            for (int i = 0; i < products.Count; i++)
            {
                added_product_sample_cb.Items.Add(products[i].ToString());
            }
        }
        private void make_third_tab()
        {
            List<Product> products = Serializator.get_product_sample_list();
            product_template_list_dg.Rows.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                product_template_list_dg.Rows.Add(products[i].product_name,
                    products[i].product_description,
                    products[i].product_price,
                    products[i].expiration_date + " день(ів)");
            }
            product_name_tb.Clear();
            product_description_tb.Clear();
            product_price_tb.Clear();
            expiration_date_tb.Clear();
        }
        private void add_product_to_current_list_btn_Click(object sender, EventArgs e)
        {
            if (product_sample_cb.SelectedIndex > -1)
            {
                try
                {
                    int x = product_sample_cb.SelectedIndex;

                    Product product = Serializator.get_product_sample_list()[x];
                    product.date_of_manufacture = new Date(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    Tuple<int, Product> tuple = Tuple.Create(int.Parse(product_count_tb.Text), product);
                    currentProductList.Add(tuple);

                    current_product_list_dg.Rows.Add(product.product_name, tuple.Item1, product.product_price, product.date_of_manufacture.ToString());
                }
                catch
                {
                    MessageBox.Show("Ви ввели якесь значення неправильно", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали продукт, який хочете добавити", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_product_from_list_btn_Click(object sender, EventArgs e)
        {
            if(current_product_list_dg.Rows.Count > 0)
            {
                currentProductList.RemoveAt(current_product_list_dg.CurrentCell.RowIndex);
                current_product_list_dg.Rows.RemoveAt(current_product_list_dg.CurrentCell.RowIndex);
                //MessageBox.Show(current_product_list_dg.CurrentCell.RowIndex.ToString());
            }
            else
            {
                MessageBox.Show("Ви не вибрали продукт, який хочете видалити", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void add_shop_to_list_btn_Click(object sender, EventArgs e)
        {
            int id = Serializator.get_shop_list().Count;
            string shop_spec = "Не вибрано";
            if (shop_spec_cb.Text.Length > 0 || shop_spec_tb.Text.Length > 0)
            {
                shop_spec = (shop_spec_tb.Text.Length > 0) ? shop_spec_tb.Text : shop_spec_cb.Text;
            }

            if (currentProductList.Count > 0)
            {

                try
                {
                    bool isGoodPhoneNum = true;

                    for(int i = 0; i < phone_number_box.Text.Length; i++)
                    {
                        if (!char.IsDigit(phone_number_box.Text[i]))
                        {
                            isGoodPhoneNum = false; break;
                        }
                    }

                    if (phone_number_box.Text.Length > 0 && isGoodPhoneNum)
                    {
                        //Serializator.add_shop_to_list(new Shop(id, shop_name_tb.Text, shop_spec, phone_number_box.Text,
                        //    new Time(int.Parse(cbStartTimeHour.Text), int.Parse(cbStartTimeMinute.Text)), new Time(int.Parse(cbEndTimeHour.Text), int.Parse(cbEndTimeMinute.Text)),
                        //    new Adress(city_tb.Text, street_tb.Text, int.Parse(number_tb.Text)), currentProductList));
                        reg_pass_form _Form = new reg_pass_form(new Shop(id, shop_name_tb.Text, shop_spec, phone_number_box.Text,
                            new Time(int.Parse(cbStartTimeHour.Text), int.Parse(cbStartTimeMinute.Text)), new Time(int.Parse(cbEndTimeHour.Text), int.Parse(cbEndTimeMinute.Text)),
                            new Adress(city_tb.Text, street_tb.Text, int.Parse(number_tb.Text)), currentProductList));
                        _Form.ShowDialog();
                        make_first_tab();
                    }
                    else
                        MessageBox.Show("Введений вами номер телефону не є коректним", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Ви ввели якесь поле некоректно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Список продуктів не може бути пустим", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void delete_product_sample_from_list_btn_Click(object sender, EventArgs e)
        {
            if(product_template_list_dg.CurrentCell!= null)
            {
                Serializator.delete_product_sample_from_list(product_template_list_dg.CurrentCell.RowIndex);
                product_template_list_dg.Rows.RemoveAt(product_template_list_dg.CurrentCell.RowIndex);
            }
        }

        private void add_product_to_selected_shop_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_selected_shop_Click(object sender, EventArgs e)
        {

        }
    }
}
