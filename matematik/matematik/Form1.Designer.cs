namespace matematik
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.lb_o24 = new System.Windows.Forms.ListBox();
            this.txt_o24_3 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.txt_o24_2 = new System.Windows.Forms.TextBox();
            this.txt_o24_1 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.lb_o_24 = new System.Windows.Forms.Label();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.groupBox29.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.lb_o24);
            this.groupBox29.Controls.Add(this.txt_sonuc);
            this.groupBox29.Controls.Add(this.txt_o24_3);
            this.groupBox29.Controls.Add(this.lb_o_24);
            this.groupBox29.Controls.Add(this.label45);
            this.groupBox29.Controls.Add(this.button32);
            this.groupBox29.Controls.Add(this.txt_o24_2);
            this.groupBox29.Controls.Add(this.txt_o24_1);
            this.groupBox29.Controls.Add(this.label46);
            this.groupBox29.Controls.Add(this.label47);
            this.groupBox29.Location = new System.Drawing.Point(12, 12);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(496, 299);
            this.groupBox29.TabIndex = 29;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = " Örnek 24";
            // 
            // lb_o24
            // 
            this.lb_o24.FormattingEnabled = true;
            this.lb_o24.ItemHeight = 16;
            this.lb_o24.Location = new System.Drawing.Point(325, 29);
            this.lb_o24.Name = "lb_o24";
            this.lb_o24.Size = new System.Drawing.Size(152, 244);
            this.lb_o24.TabIndex = 9;
            // 
            // txt_o24_3
            // 
            this.txt_o24_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_o24_3.Location = new System.Drawing.Point(178, 142);
            this.txt_o24_3.Name = "txt_o24_3";
            this.txt_o24_3.Size = new System.Drawing.Size(75, 38);
            this.txt_o24_3.TabIndex = 8;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.Location = new System.Drawing.Point(-5, 151);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(142, 25);
            this.label45.TabIndex = 7;
            this.label45.Text = "Eleman Sayısı:";
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button32.Location = new System.Drawing.Point(164, 240);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(109, 54);
            this.button32.TabIndex = 6;
            this.button32.Text = "hesapla";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // txt_o24_2
            // 
            this.txt_o24_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_o24_2.Location = new System.Drawing.Point(178, 76);
            this.txt_o24_2.Name = "txt_o24_2";
            this.txt_o24_2.Size = new System.Drawing.Size(75, 38);
            this.txt_o24_2.TabIndex = 4;
            // 
            // txt_o24_1
            // 
            this.txt_o24_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_o24_1.Location = new System.Drawing.Point(177, 26);
            this.txt_o24_1.Name = "txt_o24_1";
            this.txt_o24_1.Size = new System.Drawing.Size(76, 38);
            this.txt_o24_1.TabIndex = 3;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label46.Location = new System.Drawing.Point(54, 39);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(83, 25);
            this.label46.TabIndex = 2;
            this.label46.Text = "Sayi 1 : ";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.Location = new System.Drawing.Point(59, 95);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(78, 25);
            this.label47.TabIndex = 1;
            this.label47.Text = "Sayi 2 :";
            // 
            // lb_o_24
            // 
            this.lb_o_24.AutoSize = true;
            this.lb_o_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_o_24.Location = new System.Drawing.Point(-5, 196);
            this.lb_o_24.Name = "lb_o_24";
            this.lb_o_24.Size = new System.Drawing.Size(137, 25);
            this.lb_o_24.TabIndex = 7;
            this.lb_o_24.Text = "en küçük sayı:";
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sonuc.Location = new System.Drawing.Point(178, 196);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(75, 38);
            this.txt_sonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox29);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.ListBox lb_o24;
        private System.Windows.Forms.TextBox txt_o24_3;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.TextBox txt_o24_2;
        private System.Windows.Forms.TextBox txt_o24_1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label lb_o_24;
        private System.Windows.Forms.TextBox txt_sonuc;
    }
}

