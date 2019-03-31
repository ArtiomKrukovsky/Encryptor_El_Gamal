namespace Gamal_2._0
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
            this.DeEncrypt_textbox = new System.Windows.Forms.TextBox();
            this.btn_DeEncrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rez_tex_box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Y_textbox = new System.Windows.Forms.TextBox();
            this.G_textbox = new System.Windows.Forms.TextBox();
            this.X_textbox = new System.Windows.Forms.TextBox();
            this.P_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sms_textbox = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeEncrypt_textbox
            // 
            this.DeEncrypt_textbox.Location = new System.Drawing.Point(19, 26);
            this.DeEncrypt_textbox.Name = "DeEncrypt_textbox";
            this.DeEncrypt_textbox.Size = new System.Drawing.Size(212, 20);
            this.DeEncrypt_textbox.TabIndex = 16;
            // 
            // btn_DeEncrypt
            // 
            this.btn_DeEncrypt.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeEncrypt.Location = new System.Drawing.Point(19, 52);
            this.btn_DeEncrypt.Name = "btn_DeEncrypt";
            this.btn_DeEncrypt.Size = new System.Drawing.Size(109, 25);
            this.btn_DeEncrypt.TabIndex = 15;
            this.btn_DeEncrypt.Text = "Расшифровать";
            this.btn_DeEncrypt.UseVisualStyleBackColor = true;
            this.btn_DeEncrypt.Click += new System.EventHandler(this.btn_DeEncrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(75, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Шифротекст:";
            // 
            // rez_tex_box
            // 
            this.rez_tex_box.Location = new System.Drawing.Point(189, 65);
            this.rez_tex_box.Name = "rez_tex_box";
            this.rez_tex_box.Size = new System.Drawing.Size(109, 20);
            this.rez_tex_box.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.DeEncrypt_textbox);
            this.panel2.Controls.Add(this.btn_DeEncrypt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rez_tex_box);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 90);
            this.panel2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(189, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Расшифровка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(169, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(168, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(233, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(168, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(199, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ключи:";
            // 
            // Y_textbox
            // 
            this.Y_textbox.Enabled = false;
            this.Y_textbox.Location = new System.Drawing.Point(184, 65);
            this.Y_textbox.Name = "Y_textbox";
            this.Y_textbox.Size = new System.Drawing.Size(33, 20);
            this.Y_textbox.TabIndex = 17;
            // 
            // G_textbox
            // 
            this.G_textbox.Enabled = false;
            this.G_textbox.Location = new System.Drawing.Point(184, 44);
            this.G_textbox.Name = "G_textbox";
            this.G_textbox.Size = new System.Drawing.Size(33, 20);
            this.G_textbox.TabIndex = 18;
            // 
            // X_textbox
            // 
            this.X_textbox.Enabled = false;
            this.X_textbox.Location = new System.Drawing.Point(248, 23);
            this.X_textbox.Name = "X_textbox";
            this.X_textbox.Size = new System.Drawing.Size(33, 20);
            this.X_textbox.TabIndex = 19;
            // 
            // P_textbox
            // 
            this.P_textbox.Enabled = false;
            this.P_textbox.Location = new System.Drawing.Point(184, 23);
            this.P_textbox.Name = "P_textbox";
            this.P_textbox.Size = new System.Drawing.Size(33, 20);
            this.P_textbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Текст шифрования:";
            // 
            // sms_textbox
            // 
            this.sms_textbox.Location = new System.Drawing.Point(37, 32);
            this.sms_textbox.Name = "sms_textbox";
            this.sms_textbox.Size = new System.Drawing.Size(109, 20);
            this.sms_textbox.TabIndex = 21;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_encrypt.Location = new System.Drawing.Point(37, 58);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(95, 25);
            this.btn_encrypt.TabIndex = 16;
            this.btn_encrypt.Text = "Зашифровать";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 94);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 190);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Y_textbox);
            this.Controls.Add(this.G_textbox);
            this.Controls.Add(this.X_textbox);
            this.Controls.Add(this.P_textbox);
            this.Controls.Add(this.sms_textbox);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamal";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DeEncrypt_textbox;
        private System.Windows.Forms.Button btn_DeEncrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rez_tex_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y_textbox;
        private System.Windows.Forms.TextBox G_textbox;
        private System.Windows.Forms.TextBox X_textbox;
        private System.Windows.Forms.TextBox P_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sms_textbox;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Panel panel1;
    }
}

