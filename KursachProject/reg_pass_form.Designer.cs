namespace KursachProject
{
    partial class reg_pass_form
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
            this.pass2_tb = new System.Windows.Forms.TextBox();
            this.pass1_tb = new System.Windows.Forms.TextBox();
            this.is_ready_btn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pass2_tb
            // 
            this.pass2_tb.Location = new System.Drawing.Point(68, 180);
            this.pass2_tb.Multiline = true;
            this.pass2_tb.Name = "pass2_tb";
            this.pass2_tb.Size = new System.Drawing.Size(306, 48);
            this.pass2_tb.TabIndex = 0;
            // 
            // pass1_tb
            // 
            this.pass1_tb.Location = new System.Drawing.Point(68, 101);
            this.pass1_tb.Multiline = true;
            this.pass1_tb.Name = "pass1_tb";
            this.pass1_tb.Size = new System.Drawing.Size(306, 48);
            this.pass1_tb.TabIndex = 0;
            // 
            // is_ready_btn
            // 
            this.is_ready_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.is_ready_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_ready_btn.ForeColor = System.Drawing.Color.White;
            this.is_ready_btn.Location = new System.Drawing.Point(134, 272);
            this.is_ready_btn.Name = "is_ready_btn";
            this.is_ready_btn.Size = new System.Drawing.Size(162, 50);
            this.is_ready_btn.TabIndex = 22;
            this.is_ready_btn.Text = "Готово";
            this.is_ready_btn.UseVisualStyleBackColor = false;
            this.is_ready_btn.Click += new System.EventHandler(this.is_ready_btn_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(262, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(162, 36);
            this.close.TabIndex = 23;
            this.close.Text = "Відмінити";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // info_btn
            // 
            this.info_btn.BackColor = System.Drawing.Color.Blue;
            this.info_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.ForeColor = System.Drawing.Color.White;
            this.info_btn.Location = new System.Drawing.Point(12, 2);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(64, 64);
            this.info_btn.TabIndex = 23;
            this.info_btn.Text = "🛈";
            this.info_btn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(120, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Підтвердіть пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(147, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Введіть пароль";
            // 
            // reg_pass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(436, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.is_ready_btn);
            this.Controls.Add(this.pass1_tb);
            this.Controls.Add(this.pass2_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reg_pass_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reg_pass_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass2_tb;
        private System.Windows.Forms.TextBox pass1_tb;
        private System.Windows.Forms.Button is_ready_btn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}