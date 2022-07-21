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
                product_name_tb.Clear();
                product_description_tb.Clear();
                product_price_tb.Clear();
                expiration_date_tb.Clear();
            }
            catch {
                MessageBox.Show("Одне або кілька полів було заповнено некоректно", "Увага", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void main_tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((TabControl)sender).SelectedIndex == 0)
            {
                make_first_tab();
            }
        }
        private void make_first_tab()
        {
            product_sample_cb.Items.Clear();
            List<Product> products = Serializator.get_product_sample_list();
            for (int i = 0; i < products.Count; i++)
            {
                product_sample_cb.Items.Add(products[i].ToString());
            }
            current_product_list_dg.Rows.Clear();
            currentProductList.Clear();
        }

        private void add_product_to_current_list_btn_Click(object sender, EventArgs e)
        {
            if (product_sample_cb.SelectedIndex > -1)
            {
                try
                {
                    int x = product_sample_cb.SelectedIndex;

                    Product product = Serializator.get_product_sample_list()[x];
                    Tuple<int, Product> tuple = Tuple.Create(int.Parse(product_count_tb.Text), product);
                    currentProductList.Add(tuple);

                    current_product_list_dg.Rows.Add(product.product_name, tuple.Item1, product.product_price);
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
                    Serializator.add_shop_to_list(new Shop(id, shop_name_tb.Text, shop_spec,
                    new Adress(city_tb.Text, street_tb.Text, int.Parse(number_tb.Text))));
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
    }
}
