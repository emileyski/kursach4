namespace KursachProject
{
    partial class edit_shop_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.is_ready_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbEndTimeMinute = new System.Windows.Forms.ComboBox();
            this.cbEndTimeHour = new System.Windows.Forms.ComboBox();
            this.cbStartTimeMinute = new System.Windows.Forms.ComboBox();
            this.cbStartTimeHour = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.delete_product_from_list_btn = new System.Windows.Forms.Button();
            this.current_product_list_dg = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_manufacturing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number_box = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.number_tb = new System.Windows.Forms.TextBox();
            this.street_tb = new System.Windows.Forms.TextBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.shop_spec_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shop_spec_tb = new System.Windows.Forms.TextBox();
            this.shop_name_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_product_to_selected_shop_btn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.product_count_tb = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.added_product_sample_cb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_password_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.current_product_list_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // is_ready_btn
            // 
            this.is_ready_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.is_ready_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_ready_btn.ForeColor = System.Drawing.Color.White;
            this.is_ready_btn.Location = new System.Drawing.Point(395, 150);
            this.is_ready_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.is_ready_btn.Name = "is_ready_btn";
            this.is_ready_btn.Size = new System.Drawing.Size(183, 35);
            this.is_ready_btn.TabIndex = 23;
            this.is_ready_btn.Text = "Зберегти зміни";
            this.is_ready_btn.UseVisualStyleBackColor = false;
            this.is_ready_btn.Click += new System.EventHandler(this.is_ready_btn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(194, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 74);
            this.panel7.TabIndex = 46;
            // 
            // cbEndTimeMinute
            // 
            this.cbEndTimeMinute.DropDownHeight = 100;
            this.cbEndTimeMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEndTimeMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbEndTimeMinute.FormattingEnabled = true;
            this.cbEndTimeMinute.IntegralHeight = false;
            this.cbEndTimeMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbEndTimeMinute.Location = new System.Drawing.Point(301, 149);
            this.cbEndTimeMinute.Name = "cbEndTimeMinute";
            this.cbEndTimeMinute.Size = new System.Drawing.Size(70, 33);
            this.cbEndTimeMinute.TabIndex = 58;
            this.cbEndTimeMinute.Text = "хв.";
            // 
            // cbEndTimeHour
            // 
            this.cbEndTimeHour.DropDownHeight = 100;
            this.cbEndTimeHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEndTimeHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbEndTimeHour.FormattingEnabled = true;
            this.cbEndTimeHour.IntegralHeight = false;
            this.cbEndTimeHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbEndTimeHour.Location = new System.Drawing.Point(216, 149);
            this.cbEndTimeHour.Name = "cbEndTimeHour";
            this.cbEndTimeHour.Size = new System.Drawing.Size(70, 33);
            this.cbEndTimeHour.TabIndex = 57;
            this.cbEndTimeHour.Text = "год.";
            // 
            // cbStartTimeMinute
            // 
            this.cbStartTimeMinute.DropDownHeight = 100;
            this.cbStartTimeMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStartTimeMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbStartTimeMinute.FormattingEnabled = true;
            this.cbStartTimeMinute.IntegralHeight = false;
            this.cbStartTimeMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbStartTimeMinute.Location = new System.Drawing.Point(94, 149);
            this.cbStartTimeMinute.Name = "cbStartTimeMinute";
            this.cbStartTimeMinute.Size = new System.Drawing.Size(70, 33);
            this.cbStartTimeMinute.TabIndex = 56;
            this.cbStartTimeMinute.Text = "хв.";
            // 
            // cbStartTimeHour
            // 
            this.cbStartTimeHour.DropDownHeight = 100;
            this.cbStartTimeHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStartTimeHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbStartTimeHour.FormattingEnabled = true;
            this.cbStartTimeHour.IntegralHeight = false;
            this.cbStartTimeHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbStartTimeHour.Location = new System.Drawing.Point(14, 149);
            this.cbStartTimeHour.Name = "cbStartTimeHour";
            this.cbStartTimeHour.Size = new System.Drawing.Size(70, 33);
            this.cbStartTimeHour.TabIndex = 55;
            this.cbStartTimeHour.Text = "год.";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel8.Location = new System.Drawing.Point(-6, 109);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(394, 10);
            this.panel8.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 25);
            this.label17.TabIndex = 54;
            this.label17.Text = "до:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 25);
            this.label16.TabIndex = 53;
            this.label16.Text = "Працює з";
            // 
            // delete_product_from_list_btn
            // 
            this.delete_product_from_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_product_from_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_product_from_list_btn.ForeColor = System.Drawing.Color.White;
            this.delete_product_from_list_btn.Location = new System.Drawing.Point(673, 390);
            this.delete_product_from_list_btn.Name = "delete_product_from_list_btn";
            this.delete_product_from_list_btn.Size = new System.Drawing.Size(126, 73);
            this.delete_product_from_list_btn.TabIndex = 52;
            this.delete_product_from_list_btn.Text = "Видалити товар";
            this.delete_product_from_list_btn.UseVisualStyleBackColor = false;
            this.delete_product_from_list_btn.Click += new System.EventHandler(this.delete_product_from_list_btn_Click);
            // 
            // current_product_list_dg
            // 
            this.current_product_list_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.current_product_list_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.product_count,
            this.product_price,
            this.date_of_manufacturing,
            this.expiration_date_column,
            this.days});
            this.current_product_list_dg.Location = new System.Drawing.Point(0, 201);
            this.current_product_list_dg.MultiSelect = false;
            this.current_product_list_dg.Name = "current_product_list_dg";
            this.current_product_list_dg.RowHeadersVisible = false;
            this.current_product_list_dg.RowHeadersWidth = 51;
            this.current_product_list_dg.RowTemplate.Height = 24;
            this.current_product_list_dg.Size = new System.Drawing.Size(504, 274);
            this.current_product_list_dg.TabIndex = 51;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Товар";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 125;
            // 
            // product_count
            // 
            this.product_count.HeaderText = "Кількість";
            this.product_count.MinimumWidth = 6;
            this.product_count.Name = "product_count";
            this.product_count.ReadOnly = true;
            this.product_count.Width = 125;
            // 
            // product_price
            // 
            this.product_price.HeaderText = "Ціна";
            this.product_price.MinimumWidth = 6;
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            this.product_price.Width = 125;
            // 
            // date_of_manufacturing
            // 
            this.date_of_manufacturing.HeaderText = "Дата виготовлення";
            this.date_of_manufacturing.MinimumWidth = 6;
            this.date_of_manufacturing.Name = "date_of_manufacturing";
            this.date_of_manufacturing.ReadOnly = true;
            this.date_of_manufacturing.Width = 125;
            // 
            // expiration_date_column
            // 
            this.expiration_date_column.HeaderText = "Термін придатності";
            this.expiration_date_column.MinimumWidth = 6;
            this.expiration_date_column.Name = "expiration_date_column";
            this.expiration_date_column.ReadOnly = true;
            this.expiration_date_column.Width = 125;
            // 
            // days
            // 
            this.days.HeaderText = "Днів до псування";
            this.days.MinimumWidth = 6;
            this.days.Name = "days";
            this.days.ReadOnly = true;
            this.days.Width = 125;
            // 
            // phone_number_box
            // 
            this.phone_number_box.Location = new System.Drawing.Point(599, 102);
            this.phone_number_box.Name = "phone_number_box";
            this.phone_number_box.Size = new System.Drawing.Size(205, 30);
            this.phone_number_box.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(-6, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(825, 10);
            this.panel5.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(381, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 196);
            this.panel4.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(381, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 10);
            this.panel3.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Номер телефону";
            // 
            // number_tb
            // 
            this.number_tb.Location = new System.Drawing.Point(304, 78);
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(71, 30);
            this.number_tb.TabIndex = 48;
            // 
            // street_tb
            // 
            this.street_tb.Location = new System.Drawing.Point(97, 78);
            this.street_tb.Name = "street_tb";
            this.street_tb.Size = new System.Drawing.Size(119, 30);
            this.street_tb.TabIndex = 45;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(246, 42);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(125, 30);
            this.city_tb.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(384, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 10);
            this.panel2.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Вибрати іcнуючу";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shop_spec_cb
            // 
            this.shop_spec_cb.FormattingEnabled = true;
            this.shop_spec_cb.Location = new System.Drawing.Point(588, 47);
            this.shop_spec_cb.Name = "shop_spec_cb";
            this.shop_spec_cb.Size = new System.Drawing.Size(216, 33);
            this.shop_spec_cb.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Вулиця";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Місто";
            // 
            // shop_spec_tb
            // 
            this.shop_spec_tb.Location = new System.Drawing.Point(588, 5);
            this.shop_spec_tb.Multiline = true;
            this.shop_spec_tb.Name = "shop_spec_tb";
            this.shop_spec_tb.Size = new System.Drawing.Size(216, 36);
            this.shop_spec_tb.TabIndex = 34;
            // 
            // shop_name_tb
            // 
            this.shop_name_tb.Location = new System.Drawing.Point(168, 5);
            this.shop_name_tb.Name = "shop_name_tb";
            this.shop_name_tb.Size = new System.Drawing.Size(205, 30);
            this.shop_name_tb.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Спеціалізація";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Адреса:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Назва магазину";
            // 
            // add_product_to_selected_shop_btn
            // 
            this.add_product_to_selected_shop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_product_to_selected_shop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_to_selected_shop_btn.ForeColor = System.Drawing.Color.White;
            this.add_product_to_selected_shop_btn.Location = new System.Drawing.Point(535, 390);
            this.add_product_to_selected_shop_btn.Name = "add_product_to_selected_shop_btn";
            this.add_product_to_selected_shop_btn.Size = new System.Drawing.Size(113, 73);
            this.add_product_to_selected_shop_btn.TabIndex = 65;
            this.add_product_to_selected_shop_btn.Text = "Додати товар";
            this.add_product_to_selected_shop_btn.UseVisualStyleBackColor = false;
            this.add_product_to_selected_shop_btn.Click += new System.EventHandler(this.add_product_to_selected_shop_btn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(562, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 25);
            this.label18.TabIndex = 64;
            this.label18.Text = "Дата виготовлення";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 30);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // product_count_tb
            // 
            this.product_count_tb.Location = new System.Drawing.Point(689, 255);
            this.product_count_tb.Name = "product_count_tb";
            this.product_count_tb.Size = new System.Drawing.Size(115, 30);
            this.product_count_tb.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(521, 255);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 25);
            this.label19.TabIndex = 61;
            this.label19.Text = "Кількість товару";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(521, 209);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 25);
            this.label20.TabIndex = 60;
            this.label20.Text = "Виберіть товар";
            // 
            // added_product_sample_cb
            // 
            this.added_product_sample_cb.FormattingEnabled = true;
            this.added_product_sample_cb.Location = new System.Drawing.Point(672, 201);
            this.added_product_sample_cb.Name = "added_product_sample_cb";
            this.added_product_sample_cb.Size = new System.Drawing.Size(132, 33);
            this.added_product_sample_cb.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(510, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 282);
            this.panel1.TabIndex = 44;
            // 
            // edit_password_btn
            // 
            this.edit_password_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_password_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_password_btn.ForeColor = System.Drawing.Color.White;
            this.edit_password_btn.Location = new System.Drawing.Point(621, 149);
            this.edit_password_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_password_btn.Name = "edit_password_btn";
            this.edit_password_btn.Size = new System.Drawing.Size(183, 35);
            this.edit_password_btn.TabIndex = 66;
            this.edit_password_btn.Text = "Змінити пароль";
            this.edit_password_btn.UseVisualStyleBackColor = false;
            this.edit_password_btn.Click += new System.EventHandler(this.edit_password_btn_Click);
            // 
            // edit_shop_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(811, 475);
            this.Controls.Add(this.edit_password_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_product_to_selected_shop_btn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.product_count_tb);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.added_product_sample_cb);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cbEndTimeMinute);
            this.Controls.Add(this.cbEndTimeHour);
            this.Controls.Add(this.cbStartTimeMinute);
            this.Controls.Add(this.cbStartTimeHour);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.delete_product_from_list_btn);
            this.Controls.Add(this.current_product_list_dg);
            this.Controls.Add(this.phone_number_box);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.number_tb);
            this.Controls.Add(this.street_tb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.shop_spec_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.shop_spec_tb);
            this.Controls.Add(this.shop_name_tb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.is_ready_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "edit_shop_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змінити магазин";
            ((System.ComponentModel.ISupportInitialize)(this.current_product_list_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button is_ready_btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbEndTimeMinute;
        private System.Windows.Forms.ComboBox cbEndTimeHour;
        private System.Windows.Forms.ComboBox cbStartTimeMinute;
        private System.Windows.Forms.ComboBox cbStartTimeHour;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button delete_product_from_list_btn;
        private System.Windows.Forms.DataGridView current_product_list_dg;
        private System.Windows.Forms.TextBox phone_number_box;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox number_tb;
        private System.Windows.Forms.TextBox street_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox shop_spec_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox shop_spec_tb;
        private System.Windows.Forms.TextBox shop_name_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_manufacturing;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.Button add_product_to_selected_shop_btn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox product_count_tb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox added_product_sample_cb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_password_btn;
    }
}