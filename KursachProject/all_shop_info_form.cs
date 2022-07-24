using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursachProject.Model;

namespace KursachProject
{
    public partial class all_shop_info_form : Form
    {
        internal all_shop_info_form(Shop shop)
        {
            InitializeComponent();
    
            name_lb.Text = shop.shop_name;
            specialization_lb.Text = shop.shop_specialization;
            adress_lb.Text = shop.adress.ToString();
            label.Text = shop.phone_number;
            start_time_lb.Text = shop.open_time.ToString();
            close_time_lb.Text = shop.close_time.ToString();



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
    }
}
