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
using KursachProject.Controller;

namespace KursachProject
{
    public partial class reg_pass_form : Form
    {
        private Shop current_shop;
        internal reg_pass_form(Shop shop)
        {
            InitializeComponent();
            current_shop = shop;
        }

        private void is_ready_btn_Click(object sender, EventArgs e)
        {
            if (pass1_tb.Text.Length > 5 && pass2_tb.Text == pass1_tb.Text)
            {
                Serializator.add_shop_to_list(current_shop);
                Close();
            }
            else
            {
                MessageBox.Show("Введений вами пароль не є коректним, (тобто коротший ніж 6 символів) або ж вони не співпадають", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
