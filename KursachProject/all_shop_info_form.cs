using System;
using System.Drawing;
using System.Windows.Forms;
using KursachProject.Model;
using Excel = Microsoft.Office.Interop.Excel;

namespace KursachProject
{
    public partial class all_shop_info_form : Form
    {
        Shop shop;

        internal all_shop_info_form(Shop shop)
        {
            InitializeComponent();

            name_lb.Text = shop.shop_name;
            specialization_lb.Text = shop.shop_specialization;
            adress_lb.Text = shop.adress.ToString();
            label.Text = shop.phone_number;
            start_time_lb.Text = shop.open_time.ToString();
            close_time_lb.Text = shop.close_time.ToString();

            this.shop = shop;

            current_product_list_dg.AllowUserToAddRows = false;

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
                if (product.time_to_spoil() < 1)
                {
                    current_product_list_dg.Rows[i].DefaultCellStyle = style;
                }

            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void all_about_product_btn_Click(object sender, EventArgs e)
        {
            Product product = shop.products[current_product_list_dg.CurrentCell.RowIndex].Item2;
            MessageBox.Show("Назва продукту: " + product.product_name +
                "\nОпис продукту: " + product.product_description +
                "\nЦіна продукту: " + product.product_price +
                "\nКількість продукту на складі: " + shop.products[current_product_list_dg.CurrentCell.RowIndex].Item1.ToString() +
                "\nДата виготовлення: " + product.date_of_manufacture.ToString() +
                "\nТермін придатності, виражений в днях: " + product.expiration_date.ToString() +
                "\nДнів до псування: " + product.time_to_spoil().ToString());
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet whs = (Excel.Worksheet)exApp.ActiveSheet;

            whs.Cells[1, 1] = "Назва магазину";
            whs.Cells[1, 2] = shop.shop_name;
            whs.Cells[2, 1] = "Спеціалізація";
            whs.Cells[2, 2] = shop.shop_specialization;
            whs.Cells[3, 1] = "Адреса";
            whs.Cells[3, 2] = shop.adress.ToString();
            whs.Cells[4, 1] = "Номер телефону";
            whs.Cells[4, 2] = "+" + shop.phone_number + ";";
            whs.Cells[5, 1] = "Працює з:";
            whs.Cells[5, 2] = "[" + shop.open_time.ToString() + "]";
            whs.Cells[6, 1] = "Працює до:";
            whs.Cells[6, 2] = "[" + shop.close_time.ToString() + "]";

            whs.Cells[7, 1] = "Назва товару";
            whs.Cells[7, 2] = "Кількість на складі";
            whs.Cells[7, 3] = "Ціна";
            whs.Cells[7, 4] = "Дата виготовлення";
            whs.Cells[7, 5] = "Термін придатності(дн.)";
            whs.Cells[7, 6] = "Днів до псування";

            int i, j;
            for (i = 0; i < shop.products.Count; i++)
            {
                Product product = shop.products[i].Item2;

                string[] row = new string[]
                {
                    product.product_name,
                    shop.products[i].Item1.ToString(),
                    product.product_price.ToString(),
                    product.date_of_manufacture.ToString(),
                    product.expiration_date.ToString(),
                   product.time_to_spoil().ToString()
                };
                for (j = 0; j < current_product_list_dg.ColumnCount; j++)
                {
                    whs.Cells[i + 8, j + 1] = row[j];
                    if (product.time_to_spoil() < 0)
                    {
                        whs.Cells[i + 8, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    }
                }
            }

            whs.Cells[shop.products.Count + 10, 3] = "Інформація актуальна на:";
            whs.Cells[shop.products.Count + 11, 3] = DateTime.Now.ToString();
            exApp.Visible = true;
        }
    }
}
