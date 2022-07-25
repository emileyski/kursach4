namespace KursachProject
{
    partial class all_shop_info_form
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
            this.current_product_list_dg = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_manufacturing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.shop_spec_lb = new System.Windows.Forms.Label();
            this.specialization_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adress_lb = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.start_time_lb = new System.Windows.Forms.Label();
            this.close_time_lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.phone_lb = new System.Windows.Forms.Label();
            this.all_about_product_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.export_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.current_product_list_dg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.current_product_list_dg.Dock = System.Windows.Forms.DockStyle.Left;
            this.current_product_list_dg.Location = new System.Drawing.Point(0, 0);
            this.current_product_list_dg.MultiSelect = false;
            this.current_product_list_dg.Name = "current_product_list_dg";
            this.current_product_list_dg.RowHeadersVisible = false;
            this.current_product_list_dg.RowHeadersWidth = 51;
            this.current_product_list_dg.RowTemplate.Height = 24;
            this.current_product_list_dg.Size = new System.Drawing.Size(609, 279);
            this.current_product_list_dg.TabIndex = 52;
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
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Назва магазину";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_lb
            // 
            this.name_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_lb.Location = new System.Drawing.Point(344, 0);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(335, 28);
            this.name_lb.TabIndex = 54;
            this.name_lb.Text = "Назва магазину";
            this.name_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shop_spec_lb
            // 
            this.shop_spec_lb.AutoSize = true;
            this.shop_spec_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shop_spec_lb.Location = new System.Drawing.Point(3, 28);
            this.shop_spec_lb.Name = "shop_spec_lb";
            this.shop_spec_lb.Size = new System.Drawing.Size(335, 28);
            this.shop_spec_lb.TabIndex = 53;
            this.shop_spec_lb.Text = "Спеціалізація";
            this.shop_spec_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // specialization_lb
            // 
            this.specialization_lb.AutoSize = true;
            this.specialization_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialization_lb.Location = new System.Drawing.Point(344, 28);
            this.specialization_lb.Name = "specialization_lb";
            this.specialization_lb.Size = new System.Drawing.Size(335, 28);
            this.specialization_lb.TabIndex = 54;
            this.specialization_lb.Text = "Назва магазину";
            this.specialization_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 28);
            this.label1.TabIndex = 53;
            this.label1.Text = "Адреса";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adress_lb
            // 
            this.adress_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adress_lb.Location = new System.Drawing.Point(344, 56);
            this.adress_lb.Name = "adress_lb";
            this.adress_lb.Size = new System.Drawing.Size(335, 28);
            this.adress_lb.TabIndex = 54;
            this.adress_lb.Text = "Назва магазину";
            this.adress_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(3, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(335, 28);
            this.label.TabIndex = 54;
            this.label.Text = "Номер телефону";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(335, 29);
            this.label17.TabIndex = 56;
            this.label17.Text = "Працює до";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(335, 27);
            this.label16.TabIndex = 55;
            this.label16.Text = "Працює з";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // start_time_lb
            // 
            this.start_time_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_time_lb.Location = new System.Drawing.Point(344, 112);
            this.start_time_lb.Name = "start_time_lb";
            this.start_time_lb.Size = new System.Drawing.Size(335, 27);
            this.start_time_lb.TabIndex = 55;
            this.start_time_lb.Text = "з";
            this.start_time_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // close_time_lb
            // 
            this.close_time_lb.AutoSize = true;
            this.close_time_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_time_lb.Location = new System.Drawing.Point(344, 139);
            this.close_time_lb.Name = "close_time_lb";
            this.close_time_lb.Size = new System.Drawing.Size(335, 29);
            this.close_time_lb.TabIndex = 56;
            this.close_time_lb.Text = "до:";
            this.close_time_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.phone_lb, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_lb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.close_time_lb, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.adress_lb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.specialization_lb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.shop_spec_lb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.start_time_lb, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 168);
            this.tableLayoutPanel1.TabIndex = 59;
            // 
            // phone_lb
            // 
            this.phone_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone_lb.Location = new System.Drawing.Point(344, 84);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(335, 28);
            this.phone_lb.TabIndex = 56;
            this.phone_lb.Text = "Номер телефону";
            this.phone_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // all_about_product_btn
            // 
            this.all_about_product_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.all_about_product_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.all_about_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_about_product_btn.ForeColor = System.Drawing.Color.White;
            this.all_about_product_btn.Location = new System.Drawing.Point(0, 0);
            this.all_about_product_btn.Name = "all_about_product_btn";
            this.all_about_product_btn.Size = new System.Drawing.Size(76, 141);
            this.all_about_product_btn.TabIndex = 60;
            this.all_about_product_btn.Text = "Все\r\nпро\r\nтовар";
            this.all_about_product_btn.UseVisualStyleBackColor = false;
            this.all_about_product_btn.Click += new System.EventHandler(this.all_about_product_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.current_product_list_dg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 279);
            this.panel1.TabIndex = 61;
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.export_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.export_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_btn.ForeColor = System.Drawing.Color.White;
            this.export_btn.Location = new System.Drawing.Point(0, 147);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(76, 132);
            this.export_btn.TabIndex = 61;
            this.export_btn.Text = "Експортувати інфо";
            this.export_btn.UseVisualStyleBackColor = false;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.all_about_product_btn);
            this.panel2.Controls.Add(this.export_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(606, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 279);
            this.panel2.TabIndex = 62;
            // 
            // all_shop_info_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "all_shop_info_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вся інформація про магазин";
            ((System.ComponentModel.ISupportInitialize)(this.current_product_list_dg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView current_product_list_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_manufacturing;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label shop_spec_lb;
        private System.Windows.Forms.Label specialization_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adress_lb;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label start_time_lb;
        private System.Windows.Forms.Label close_time_lb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label phone_lb;
        private System.Windows.Forms.Button all_about_product_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button export_btn;
    }
}