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
            this.delete_product_sample_from_list_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_product_sample_from_list_btn
            // 
            this.delete_product_sample_from_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_product_sample_from_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_product_sample_from_list_btn.ForeColor = System.Drawing.Color.White;
            this.delete_product_sample_from_list_btn.Location = new System.Drawing.Point(276, 270);
            this.delete_product_sample_from_list_btn.Name = "delete_product_sample_from_list_btn";
            this.delete_product_sample_from_list_btn.Size = new System.Drawing.Size(167, 115);
            this.delete_product_sample_from_list_btn.TabIndex = 25;
            this.delete_product_sample_from_list_btn.Text = "Видалити шаблон із списку";
            this.delete_product_sample_from_list_btn.UseVisualStyleBackColor = false;
            // 
            // all_shop_info_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(631, 564);
            this.Controls.Add(this.delete_product_sample_from_list_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "all_shop_info_form";
            this.Text = "Вся інформація про магазини";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_product_sample_from_list_btn;
    }
}