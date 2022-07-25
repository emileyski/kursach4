using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KursachProject.Controller;
using KursachProject.Model;
using Microsoft.VisualBasic;
using Excel = Microsoft.Office.Interop.Excel;


namespace KursachProject
{
    public partial class Form1 : Form
    {
        //список продуктов и их колво, необходимый для редактирования здесь и сейчас

        List<Tuple<int, Product>> currentProductList;

        //delegate Tuple<List<Product>, List<Tuple<Shop, Product>>> search_method_pattern(List<Product> products, string filter);

        //List<search_method_pattern> search_Methods;

        public Form1()
        {
            InitializeComponent();
            currentProductList = new List<Tuple<int, Product>>();
            make_first_tab();
            product_template_list_dg.AllowUserToAddRows = false;
            shop_list_dg.AllowUserToAddRows = false;
            current_product_list_dg.AllowUserToAddRows = false;
            result_dg.AllowUserToAddRows = false;

            cbSelectCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectSpec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMinCount.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_product_to_sample_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Serializator.add_product_to_sample(new Product(product_name_tb.Text,
                    product_description_tb.Text,
                    float.Parse(product_price_tb.Text),
                    int.Parse(expiration_date_tb.Text)));

                //чистим поля для ввода
                make_third_tab();
            }
            catch
            {
                MessageBox.Show("Одне або кілька полів було заповнено некоректно", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                case 3:
                    make_fourth_tab();
                    break;
            }
        }

        private void make_spec_list()
        {
            List<Shop> shops = Serializator.get_shop_list();
            for (int i = 0; i < shops.Count; i++)
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
            cbStartTimeHour_.Text = "год.";
            cbStartTimeMinute_.Text = "хв.";
            cbEndTimeHour_.Text = "год.";
            cbEndTimeMinute_.Text = "хв.";
        }
        private void make_second_tab()
        {
            shop_list_dg.Rows.Clear();
            List<Shop> shopList = Serializator.get_shop_list();
            for (int i = 0; i < shopList.Count; i++)
            {
                shop_list_dg.Rows.Add(shopList[i].shop_name,
                    shopList[i].shop_specialization,
                    shopList[i].adress.ToString(),
                    shopList[i].phone_number,
                    shopList[i].products.Count,
                    shopList[i].open_time.ToString(),
                    shopList[i].close_time.ToString());
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
        private void make_fourth_tab()
        {
            tbSearchProductName.Clear();
            tb_shop_name.Clear();
            cbSelectCity.SelectedIndex = -1;
            cbSelectSpec.SelectedIndex = -1;
            cbMinCount.SelectedIndex = -1;
            tbMaxPrice.Clear();
            check_b_fresh_products.Checked = false;
            result_dg.Rows.Clear();

            List<Shop> shops = Serializator.get_shop_list();
            for (int i = 0; i < shops.Count; i++)
            {
                if (!cbSelectCity.Items.Contains(shops[i].adress.city))
                {
                    cbSelectCity.Items.Add(shops[i].adress.city);
                }
                if (!cbSelectSpec.Items.Contains(shops[i].shop_specialization))
                {
                    cbSelectSpec.Items.Add(shops[i].shop_specialization);
                }
            }
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
            if (current_product_list_dg.Rows.Count > 0)
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

                    for (int i = 0; i < phone_number_box.Text.Length; i++)
                    {
                        if (!char.IsDigit(phone_number_box.Text[i]))
                        {
                            isGoodPhoneNum = false; break;
                        }
                    }

                    if (phone_number_box.Text.Length > 0 && isGoodPhoneNum)
                    {
                        reg_pass_form _Form = new reg_pass_form(new Shop(id, shop_name_tb.Text, shop_spec, phone_number_box.Text,
                            new Time(cbStartTimeHour_.SelectedIndex, cbStartTimeMinute_.SelectedIndex), new Time(cbEndTimeHour_.SelectedIndex, cbEndTimeMinute_.SelectedIndex),
                            new Adress(city_tb.Text, street_tb.Text, int.Parse(number_tb.Text)), currentProductList, Serializator.getHash("")));
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
            if (product_template_list_dg.CurrentCell != null)
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
            if (shop_list_dg.Rows.Count > 0)
            {
                string password;
                password = Interaction.InputBox("Введіть пароль", "Пароль");
                if (Serializator.get_shop_list()[shop_list_dg.CurrentCell.RowIndex].give_access(password))
                {
                    Serializator.delete_shop_at_index(shop_list_dg.CurrentCell.RowIndex);
                    make_second_tab();
                }
                else
                    MessageBox.Show("Ви ввели некоректний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Список магазинів і так пустий", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edit_selected_shop_btn_Click(object sender, EventArgs e)
        {

            if (shop_list_dg.Rows.Count > 0)
            {
                string password;
                password = Interaction.InputBox("Введіть пароль", "Пароль");
                //MessageBox.Show(password + "\n" + password.Length);

                if (Serializator.get_shop_list()[shop_list_dg.CurrentCell.RowIndex].give_access(password))
                {
                    Hide();
                    edit_shop_panel panel = new edit_shop_panel(Serializator.get_shop_list()[shop_list_dg.CurrentCell.RowIndex]);
                    panel.ShowDialog();
                    Show();
                    make_second_tab();
                }
                else
                    MessageBox.Show("Ви ввели некоректний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Неможливо вибрати магазин в пустому списку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void show_all_info_about_shop_btn_Click(object sender, EventArgs e)
        {
            Hide();
            all_shop_info_form form = new all_shop_info_form(Serializator.get_shop_list()[shop_list_dg.CurrentCell.RowIndex]);
            form.ShowDialog();
            Show();
        }

        private List<Tuple<int, Product>> res = new List<Tuple<int, Product>>();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Tuple<List<Shop>, List<Product>> res_tuple = InfoFinder.get_products_by_city(Serializator.get_shop_list(), cbSelectCity.Text);

            result_dg.Rows.Clear();

            List<Tuple<int, Product>> result = Serializator.get_all_products();

            if (cbSelectCity.Text.Length > 0)
            {
                result = InfoFinder.get_products_by_city(result, cbSelectCity.Text);
            }
            if (tb_shop_name.Text.Length > 0)
            {
                result = InfoFinder.get_products_by_shop_name(result, tb_shop_name.Text);
            }
            if (cbSelectSpec.Text.Length > 0)
            {
                result = InfoFinder.get_products_by_specialization(result, cbSelectSpec.Text);
            }
            if (tbSearchProductName.Text.Length > 0)
            {
                result = InfoFinder.get_products_by_product_name(result, tbSearchProductName.Text);
            }
            if (cbMinCount.Text.Length > 0)
            {
                result = InfoFinder.get_products_by_min_count(result, cbMinCount.Text);
            }
            if (tbMaxPrice.Text.Length > 0)
            {
                result = InfoFinder.get_products_by_max_price(result, tbMaxPrice.Text);
            }
            if (check_b_fresh_products.Checked)
            {
                result = InfoFinder.get_products_by_by_freshness(result);
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.Red;
            style.ForeColor = System.Drawing.Color.White;

            for (int i = 0; i < result.Count; i++)
            {
                Shop shop = result[i].Item2.get_parent_shop();
                Product product = result[i].Item2;

                result_dg.Rows.Add(product.product_name,
                    result[i].Item1,
                    shop.shop_name,
                    shop.adress.ToString(),
                    shop.phone_number,
                    shop.open_time.ToString(),
                    shop.close_time.ToString(),
                    product.time_to_spoil());
                if (product.time_to_spoil() < 1)
                {
                    result_dg.Rows[i].DefaultCellStyle = style;
                }
            }
            res = result;
        }

        private void btnClearSearchResult_Click(object sender, EventArgs e)
        {
            make_fourth_tab();
        }

        private void btnExportSearchResult_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet whs = (Excel.Worksheet)exApp.ActiveSheet;


            int i, j;
            whs.Cells[1, 1] = "Назва товару";
            whs.Cells[1, 2] = "Кількість на складі";
            whs.Cells[1, 3] = "Назва магазину";
            whs.Cells[1, 4] = "Адреса";
            whs.Cells[1, 5] = "Телефон";
            whs.Cells[1, 6] = "Відчиняється маг.:";
            whs.Cells[1, 7] = "Зачиняється маг.:";
            whs.Cells[1, 8] = "Днів до псування:";

            for (i = 0; i < result_dg.RowCount; i++)
            {
                Shop shop = res[i].Item2.get_parent_shop();
                Product product = res[i].Item2;

                string[] row = new string[]
                {
                    product.product_name,
                    res[i].Item1.ToString(),
                    shop.shop_name,
                    shop.adress.ToString(),
                    "+"+shop.phone_number +";",
                    "["+shop.open_time.ToString()+"]",
                   "["+ shop.close_time.ToString()+"]",
                    product.time_to_spoil().ToString()
                };
                for (j = 0; j < result_dg.ColumnCount; j++)
                {
                    whs.Cells[i + 2, j + 1] = row[j];
                    if (product.time_to_spoil() < 0)
                    {
                        whs.Cells[i + 2, 8].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    }
                }
            }

            

            exApp.Visible = true;
        }
    }
}
