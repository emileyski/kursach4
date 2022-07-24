using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KursachProject.Controller;
using KursachProject.Model;
using Microsoft.VisualBasic;

namespace KursachProject
{
    public partial class edit_shop_panel : Form
    {
        private Shop shop;
        private string password;

        internal edit_shop_panel(Shop shop)
        {
            InitializeComponent();
            this.shop = shop;
            current_product_list_dg.AllowUserToAddRows = false;

            //присваиваем значения текст-боксам
            shop_name_tb.Text = shop.shop_name;
            city_tb.Text = shop.adress.city;
            street_tb.Text = shop.adress.street;
            number_tb.Text = shop.adress.number.ToString();

            cbStartTimeHour.Text = shop.open_time.hour.ToString();
            cbStartTimeMinute.Text = shop.open_time.minute.ToString();
            cbEndTimeHour.Text = shop.close_time.hour.ToString();
            cbEndTimeMinute.Text = shop.close_time.minute.ToString();

            shop_spec_tb.Text = shop.shop_specialization;

            phone_number_box.Text = shop.phone_number;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            style.ForeColor = Color.White;

            for (int i = 0; i < shop.products.Count; i++)
            {
                Product product = shop.products[i].Item2;
                current_product_list_dg.Rows.Add(product.product_name,
                    shop.products[i].Item1,
                    product.product_price,
                    product.date_of_manufacture.ToString(),
                    product.expiration_date,
                    product.time_to_spoil());
                if(product.time_to_spoil() < 1)
                {
                    current_product_list_dg.Rows[i].DefaultCellStyle = style;
                }

            }


            password = shop.password;


            added_product_sample_cb.Items.Clear();
            List<Product> products = Serializator.get_product_sample_list();
            for (int i = 0; i < products.Count; i++)
            {
                added_product_sample_cb.Items.Add(products[i].ToString());
            }
            product_count_tb.Clear();
        }

        private void is_ready_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string shop_spec = "Не вибрано";
                if (shop_spec_cb.Text.Length > 0 || shop_spec_tb.Text.Length > 0)
                {
                    shop_spec = (shop_spec_tb.Text.Length > 0) ? shop_spec_tb.Text : shop_spec_cb.Text;
                }
                Shop newShop = new Shop(shop.shop_Id, shop_name_tb.Text, shop_spec, phone_number_box.Text,
                                new Time(int.Parse(cbStartTimeHour.Text), int.Parse(cbStartTimeMinute.Text)), new Time(int.Parse(cbEndTimeHour.Text), int.Parse(cbEndTimeMinute.Text)),
                                new Adress(city_tb.Text, street_tb.Text, int.Parse(number_tb.Text)), shop.products, password);
                if (newShop.Equals(shop))
                {
                    DialogResult result = MessageBox.Show("Ви ніяк не змінили поточний магазин, Ви хочете вийти не змінивши нічого?", "Ви впевнені?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    Serializator.rewrite_shop(newShop);
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Ви ввели якесь поле некоректно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void delete_product_from_list_btn_Click(object sender, EventArgs e)
        {
            if (current_product_list_dg.Rows.Count > 1)
            {
                shop.products.RemoveAt(current_product_list_dg.CurrentCell.RowIndex);
                current_product_list_dg.Rows.RemoveAt(current_product_list_dg.CurrentCell.RowIndex);
                //MessageBox.Show(current_product_list_dg.CurrentCell.RowIndex.ToString());
            }
            else
            {
                MessageBox.Show("В магазині повинен залишитися принаймні один товар", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void add_product_to_selected_shop_btn_Click(object sender, EventArgs e)
        {
            if (added_product_sample_cb.SelectedIndex > -1)
            {
                try
                {
                    int x = added_product_sample_cb.SelectedIndex;

                    Product product = Serializator.get_product_sample_list()[x];
                    product.date_of_manufacture = new Date(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    Tuple<int, Product> tuple = Tuple.Create(int.Parse(product_count_tb.Text), product);
                    shop.products.Add(tuple);

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

        private void edit_password_btn_Click(object sender, EventArgs e)
        {
            string _password;
            
            _password = Interaction.InputBox("Введіть пароль", "Пароль");
            if (Serializator.getHash(_password) == shop.password)
            {
                while (true)
                {
                    string newPassword = Interaction.InputBox("Введіть новий пароль", "Пароль");
                    string ConfirmNewPassword = Interaction.InputBox("Введіть новий пароль", "Пароль");
                    if (newPassword.Length > 5 && ConfirmNewPassword == newPassword)
                    {
                        MessageBox.Show(password);
                        password = Serializator.getHash(newPassword);
                        MessageBox.Show(password);
                        MessageBox.Show("Ви успішно змінили пароль", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Введений вами пароль не є коректним, (тобто коротший ніж 6 символів) або ж вони не співпадають", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                
        }
    }
}
