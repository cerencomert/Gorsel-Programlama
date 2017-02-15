namespace Örnek1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Degistir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Asonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hesapla = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mltextb = new System.Windows.Forms.TextBox();
            this.TekrarYaz = new System.Windows.Forms.Button();
            this.tekrartxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metintxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bol = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Degistir);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yer Değiştir";
            // 
            // Degistir
            // 
            this.Degistir.Location = new System.Drawing.Point(7, 74);
            this.Degistir.Name = "Degistir";
            this.Degistir.Size = new System.Drawing.Size(100, 23);
            this.Degistir.TabIndex = 2;
            this.Degistir.Text = "Değiştir";
            this.Degistir.UseVisualStyleBackColor = true;
            this.Degistir.Click += new System.EventHandler(this.Degistir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Asonuc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Hesapla);
            this.groupBox2.Controls.Add(this.r);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A=pi*r*r";
            // 
            // Asonuc
            // 
            this.Asonuc.Enabled = false;
            this.Asonuc.Location = new System.Drawing.Point(27, 93);
            this.Asonuc.Name = "Asonuc";
            this.Asonuc.Size = new System.Drawing.Size(79, 20);
            this.Asonuc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A=";
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(10, 55);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(97, 30);
            this.Hesapla.TabIndex = 2;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(30, 29);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(77, 20);
            this.r.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "r=";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mltextb);
            this.groupBox3.Controls.Add(this.TekrarYaz);
            this.groupBox3.Controls.Add(this.tekrartxb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.metintxb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(154, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MultiLine";
            // 
            // mltextb
            // 
            this.mltextb.Enabled = false;
            this.mltextb.Location = new System.Drawing.Point(7, 103);
            this.mltextb.Multiline = true;
            this.mltextb.Name = "mltextb";
            this.mltextb.Size = new System.Drawing.Size(149, 127);
            this.mltextb.TabIndex = 5;
            // 
            // TekrarYaz
            // 
            this.TekrarYaz.Location = new System.Drawing.Point(10, 73);
            this.TekrarYaz.Name = "TekrarYaz";
            this.TekrarYaz.Size = new System.Drawing.Size(146, 23);
            this.TekrarYaz.TabIndex = 4;
            this.TekrarYaz.Text = "Tekrar Yaz";
            this.TekrarYaz.UseVisualStyleBackColor = true;
            this.TekrarYaz.Click += new System.EventHandler(this.TekrarYaz_Click);
            // 
            // tekrartxb
            // 
            this.tekrartxb.Location = new System.Drawing.Point(56, 47);
            this.tekrartxb.Name = "tekrartxb";
            this.tekrartxb.Size = new System.Drawing.Size(100, 20);
            this.tekrartxb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tekrar ?";
            // 
            // metintxb
            // 
            this.metintxb.Location = new System.Drawing.Point(56, 20);
            this.metintxb.Name = "metintxb";
            this.metintxb.Size = new System.Drawing.Size(100, 20);
            this.metintxb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Metin ?";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sonuc);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.sayi2);
            this.groupBox4.Controls.Add(this.sayi1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(327, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 257);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mini Hesap Makinesi";
            // 
            // sonuc
            // 
            this.sonuc.Enabled = false;
            this.sonuc.Location = new System.Drawing.Point(53, 210);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(100, 20);
            this.sonuc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "SONUÇ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bol);
            this.groupBox5.Controls.Add(this.carp);
            this.groupBox5.Controls.Add(this.cikar);
            this.groupBox5.Controls.Add(this.topla);
            this.groupBox5.Location = new System.Drawing.Point(10, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 117);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlem";
            // 
            // bol
            // 
            this.bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bol.Location = new System.Drawing.Point(74, 64);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(63, 36);
            this.bol.TabIndex = 3;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = true;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // carp
            // 
            this.carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carp.Location = new System.Drawing.Point(7, 64);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(61, 36);
            this.carp.TabIndex = 2;
            this.carp.Text = "x";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // cikar
            // 
            this.cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikar.Location = new System.Drawing.Point(74, 21);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(63, 37);
            this.cikar.TabIndex = 1;
            this.cikar.Text = "-";
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // topla
            // 
            this.topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topla.Location = new System.Drawing.Point(7, 20);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(61, 38);
            this.topla.TabIndex = 0;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(53, 47);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 20);
            this.sayi2.TabIndex = 3;
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(53, 20);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 20);
            this.sayi1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "2. Sayı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "1. Sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 283);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Görsel Programlama 2.Hafta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Degistir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Asonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tekrartxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox metintxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox mltextb;
        private System.Windows.Forms.Button TekrarYaz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sonuc;
    }
}

