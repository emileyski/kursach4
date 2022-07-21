namespace KursachProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_tab_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_product_from_list_btn = new System.Windows.Forms.Button();
            this.current_product_list_dg = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_product_to_current_list_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.product_count_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.product_sample_cb = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
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
            this.add_shop_to_list_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expiration_date_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_product_to_sample_btn = new System.Windows.Forms.Button();
            this.product_price_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name_tb = new System.Windows.Forms.TextBox();
            this.product_description_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_tab_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_product_list_dg)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tab_control
            // 
            this.main_tab_control.Controls.Add(this.tabPage1);
            this.main_tab_control.Controls.Add(this.tabPage2);
            this.main_tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tab_control.Location = new System.Drawing.Point(0, 0);
            this.main_tab_control.Name = "main_tab_control";
            this.main_tab_control.SelectedIndex = 0;
            this.main_tab_control.Size = new System.Drawing.Size(819, 555);
            this.main_tab_control.TabIndex = 0;
            this.main_tab_control.SelectedIndexChanged += new System.EventHandler(this.main_tab_control_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.delete_product_from_list_btn);
            this.tabPage1.Controls.Add(this.current_product_list_dg);
            this.tabPage1.Controls.Add(this.add_product_to_current_list_btn);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.product_count_tb);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.product_sample_cb);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.number_tb);
            this.tabPage1.Controls.Add(this.street_tb);
            this.tabPage1.Controls.Add(this.city_tb);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.shop_spec_cb);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.shop_spec_tb);
            this.tabPage1.Controls.Add(this.shop_name_tb);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.add_shop_to_list_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Додати інформацію про магазин";
            // 
            // delete_product_from_list_btn
            // 
            this.delete_product_from_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_product_from_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_product_from_list_btn.ForeColor = System.Drawing.Color.White;
            this.delete_product_from_list_btn.Location = new System.Drawing.Point(525, 479);
            this.delete_product_from_list_btn.Name = "delete_product_from_list_btn";
            this.delete_product_from_list_btn.Size = new System.Drawing.Size(174, 35);
            this.delete_product_from_list_btn.TabIndex = 23;
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
            this.product_price});
            this.current_product_list_dg.Location = new System.Drawing.Point(397, 155);
            this.current_product_list_dg.MultiSelect = false;
            this.current_product_list_dg.Name = "current_product_list_dg";
            this.current_product_list_dg.RowHeadersVisible = false;
            this.current_product_list_dg.RowHeadersWidth = 51;
            this.current_product_list_dg.RowTemplate.Height = 24;
            this.current_product_list_dg.Size = new System.Drawing.Size(414, 318);
            this.current_product_list_dg.TabIndex = 22;
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
            // add_product_to_current_list_btn
            // 
            this.add_product_to_current_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_product_to_current_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_to_current_list_btn.ForeColor = System.Drawing.Color.White;
            this.add_product_to_current_list_btn.Location = new System.Drawing.Point(229, 239);
            this.add_product_to_current_list_btn.Name = "add_product_to_current_list_btn";
            this.add_product_to_current_list_btn.Size = new System.Drawing.Size(146, 98);
            this.add_product_to_current_list_btn.TabIndex = 21;
            this.add_product_to_current_list_btn.Text = "Додати товар в магазин\r\n";
            this.add_product_to_current_list_btn.UseVisualStyleBackColor = false;
            this.add_product_to_current_list_btn.Click += new System.EventHandler(this.add_product_to_current_list_btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Дата виготовлення";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 290);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // product_count_tb
            // 
            this.product_count_tb.Location = new System.Drawing.Point(182, 193);
            this.product_count_tb.Name = "product_count_tb";
            this.product_count_tb.Size = new System.Drawing.Size(191, 30);
            this.product_count_tb.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Кількість товару";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Виберіть товар";
            // 
            // product_sample_cb
            // 
            this.product_sample_cb.FormattingEnabled = true;
            this.product_sample_cb.Location = new System.Drawing.Point(173, 139);
            this.product_sample_cb.Name = "product_sample_cb";
            this.product_sample_cb.Size = new System.Drawing.Size(200, 33);
            this.product_sample_cb.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(601, 103);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(205, 30);
            this.textBox6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(0, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 10);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(383, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 523);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(383, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 10);
            this.panel3.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Номер телефону";
            // 
            // number_tb
            // 
            this.number_tb.Location = new System.Drawing.Point(306, 79);
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(71, 30);
            this.number_tb.TabIndex = 12;
            // 
            // street_tb
            // 
            this.street_tb.Location = new System.Drawing.Point(99, 79);
            this.street_tb.Name = "street_tb";
            this.street_tb.Size = new System.Drawing.Size(119, 30);
            this.street_tb.TabIndex = 11;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(248, 43);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(125, 30);
            this.city_tb.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(386, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 10);
            this.panel2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Вибрати іcнуючу";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shop_spec_cb
            // 
            this.shop_spec_cb.FormattingEnabled = true;
            this.shop_spec_cb.Location = new System.Drawing.Point(590, 48);
            this.shop_spec_cb.Name = "shop_spec_cb";
            this.shop_spec_cb.Size = new System.Drawing.Size(216, 33);
            this.shop_spec_cb.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Вулиця";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Місто";
            // 
            // shop_spec_tb
            // 
            this.shop_spec_tb.Location = new System.Drawing.Point(590, 6);
            this.shop_spec_tb.Multiline = true;
            this.shop_spec_tb.Name = "shop_spec_tb";
            this.shop_spec_tb.Size = new System.Drawing.Size(216, 36);
            this.shop_spec_tb.TabIndex = 3;
            // 
            // shop_name_tb
            // 
            this.shop_name_tb.Location = new System.Drawing.Point(170, 6);
            this.shop_name_tb.Name = "shop_name_tb";
            this.shop_name_tb.Size = new System.Drawing.Size(205, 30);
            this.shop_name_tb.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Спеціалізація";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Адреса:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Назва магазину";
            // 
            // add_shop_to_list_btn
            // 
            this.add_shop_to_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_shop_to_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_shop_to_list_btn.ForeColor = System.Drawing.Color.White;
            this.add_shop_to_list_btn.Location = new System.Drawing.Point(76, 434);
            this.add_shop_to_list_btn.Name = "add_shop_to_list_btn";
            this.add_shop_to_list_btn.Size = new System.Drawing.Size(236, 75);
            this.add_shop_to_list_btn.TabIndex = 0;
            this.add_shop_to_list_btn.Text = "Добавити інформацію про магазин";
            this.add_shop_to_list_btn.UseVisualStyleBackColor = false;
            this.add_shop_to_list_btn.Click += new System.EventHandler(this.add_shop_to_list_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.expiration_date_tb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.add_product_to_sample_btn);
            this.tabPage2.Controls.Add(this.product_price_tb);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.product_name_tb);
            this.tabPage2.Controls.Add(this.product_description_tb);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати шаблон продукту";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(470, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 521);
            this.panel1.TabIndex = 9;
            // 
            // expiration_date_tb
            // 
            this.expiration_date_tb.Location = new System.Drawing.Point(209, 282);
            this.expiration_date_tb.Name = "expiration_date_tb";
            this.expiration_date_tb.Size = new System.Drawing.Size(255, 30);
            this.expiration_date_tb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "Термін придатності\r\n(виражений в днях)";
            // 
            // add_product_to_sample_btn
            // 
            this.add_product_to_sample_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_product_to_sample_btn.ForeColor = System.Drawing.Color.White;
            this.add_product_to_sample_btn.Location = new System.Drawing.Point(220, 324);
            this.add_product_to_sample_btn.Name = "add_product_to_sample_btn";
            this.add_product_to_sample_btn.Size = new System.Drawing.Size(212, 58);
            this.add_product_to_sample_btn.TabIndex = 5;
            this.add_product_to_sample_btn.Text = "Додати продукт до списку шаблонів";
            this.add_product_to_sample_btn.UseVisualStyleBackColor = false;
            this.add_product_to_sample_btn.Click += new System.EventHandler(this.add_product_to_sample_btn_Click);
            // 
            // product_price_tb
            // 
            this.product_price_tb.Location = new System.Drawing.Point(180, 231);
            this.product_price_tb.Name = "product_price_tb";
            this.product_price_tb.Size = new System.Drawing.Size(284, 30);
            this.product_price_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ціна продукту";
            // 
            // product_name_tb
            // 
            this.product_name_tb.Location = new System.Drawing.Point(180, 15);
            this.product_name_tb.Name = "product_name_tb";
            this.product_name_tb.Size = new System.Drawing.Size(284, 30);
            this.product_name_tb.TabIndex = 1;
            // 
            // product_description_tb
            // 
            this.product_description_tb.Location = new System.Drawing.Point(180, 63);
            this.product_description_tb.Multiline = true;
            this.product_description_tb.Name = "product_description_tb";
            this.product_description_tb.Size = new System.Drawing.Size(284, 150);
            this.product_description_tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Опис продукту";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва продукту";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 555);
            this.Controls.Add(this.main_tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник покупця";
            this.main_tab_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_product_list_dg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl main_tab_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_shop_to_list_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox product_name_tb;
        private System.Windows.Forms.TextBox product_description_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_price_tb;
        private System.Windows.Forms.Button add_product_to_sample_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expiration_date_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox shop_spec_tb;
        private System.Windows.Forms.TextBox shop_name_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox shop_spec_cb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox number_tb;
        private System.Windows.Forms.TextBox street_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox product_sample_cb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox product_count_tb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button add_product_to_current_list_btn;
        private System.Windows.Forms.DataGridView current_product_list_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_product_from_list_btn;
    }
}

