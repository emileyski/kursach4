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
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_description_tb = new System.Windows.Forms.TextBox();
            this.product_name_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_price_tb = new System.Windows.Forms.TextBox();
            this.add_product_to_sample_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.expiration_date_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.main_tab_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tab_control
            // 
            this.main_tab_control.Controls.Add(this.tabPage1);
            this.main_tab_control.Controls.Add(this.tabPage2);
            this.main_tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tab_control.Location = new System.Drawing.Point(0, 97);
            this.main_tab_control.Name = "main_tab_control";
            this.main_tab_control.SelectedIndex = 0;
            this.main_tab_control.Size = new System.Drawing.Size(822, 460);
            this.main_tab_control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Додати інформацію про магазин";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(306, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 58);
            this.button2.TabIndex = 0;
            this.button2.Text = "Добавити інформацію про магазин";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.tabPage2.Size = new System.Drawing.Size(814, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати шаблон продукту";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 101);
            this.panel1.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(735, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 75);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Опис продукту";
            // 
            // product_description_tb
            // 
            this.product_description_tb.Location = new System.Drawing.Point(180, 63);
            this.product_description_tb.Multiline = true;
            this.product_description_tb.Name = "product_description_tb";
            this.product_description_tb.Size = new System.Drawing.Size(284, 150);
            this.product_description_tb.TabIndex = 2;
            // 
            // product_name_tb
            // 
            this.product_name_tb.Location = new System.Drawing.Point(180, 15);
            this.product_name_tb.Name = "product_name_tb";
            this.product_name_tb.Size = new System.Drawing.Size(284, 30);
            this.product_name_tb.TabIndex = 1;
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
            // product_price_tb
            // 
            this.product_price_tb.Location = new System.Drawing.Point(180, 231);
            this.product_price_tb.Name = "product_price_tb";
            this.product_price_tb.Size = new System.Drawing.Size(284, 30);
            this.product_price_tb.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "Термін придатності\r\n(виражений в днях)";
            // 
            // expiration_date_tb
            // 
            this.expiration_date_tb.Location = new System.Drawing.Point(209, 282);
            this.expiration_date_tb.Name = "expiration_date_tb";
            this.expiration_date_tb.Size = new System.Drawing.Size(255, 30);
            this.expiration_date_tb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Назва магазину";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.main_tab_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl main_tab_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button button2;
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
    }
}

