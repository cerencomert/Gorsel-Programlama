namespace Örnek3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sinirasimi = new System.Windows.Forms.Button();
            this.formatuyusmazligi = new System.Windows.Forms.Button();
            this.sifirabolunme = new System.Windows.Forms.Button();
            this.sbfinally = new System.Windows.Forms.Button();
            this.outofrange = new System.Windows.Forms.Button();
            this.tekbutondakontrol = new System.Windows.Forms.Button();
            this.manuelex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // sinirasimi
            // 
            this.sinirasimi.Location = new System.Drawing.Point(16, 64);
            this.sinirasimi.Name = "sinirasimi";
            this.sinirasimi.Size = new System.Drawing.Size(148, 23);
            this.sinirasimi.TabIndex = 4;
            this.sinirasimi.Text = "Sınır Aşımı";
            this.sinirasimi.UseVisualStyleBackColor = true;
            this.sinirasimi.Click += new System.EventHandler(this.sinirasimi_Click);
            // 
            // formatuyusmazligi
            // 
            this.formatuyusmazligi.Location = new System.Drawing.Point(16, 93);
            this.formatuyusmazligi.Name = "formatuyusmazligi";
            this.formatuyusmazligi.Size = new System.Drawing.Size(148, 23);
            this.formatuyusmazligi.TabIndex = 5;
            this.formatuyusmazligi.Text = "Format Uyuşmazlığı";
            this.formatuyusmazligi.UseVisualStyleBackColor = true;
            this.formatuyusmazligi.Click += new System.EventHandler(this.formatuyusmazligi_Click);
            // 
            // sifirabolunme
            // 
            this.sifirabolunme.Location = new System.Drawing.Point(16, 122);
            this.sifirabolunme.Name = "sifirabolunme";
            this.sifirabolunme.Size = new System.Drawing.Size(148, 23);
            this.sifirabolunme.TabIndex = 6;
            this.sifirabolunme.Text = "Sıfıra Bölünme";
            this.sifirabolunme.UseVisualStyleBackColor = true;
            this.sifirabolunme.Click += new System.EventHandler(this.sifirabolunme_Click);
            // 
            // sbfinally
            // 
            this.sbfinally.Location = new System.Drawing.Point(16, 151);
            this.sbfinally.Name = "sbfinally";
            this.sbfinally.Size = new System.Drawing.Size(148, 23);
            this.sbfinally.TabIndex = 7;
            this.sbfinally.Text = "Sıfıra Bölünme/ Finally";
            this.sbfinally.UseVisualStyleBackColor = true;
            this.sbfinally.Click += new System.EventHandler(this.sbfinally_Click);
            // 
            // outofrange
            // 
            this.outofrange.Location = new System.Drawing.Point(16, 180);
            this.outofrange.Name = "outofrange";
            this.outofrange.Size = new System.Drawing.Size(148, 23);
            this.outofrange.TabIndex = 8;
            this.outofrange.Text = "OuOfRange";
            this.outofrange.UseVisualStyleBackColor = true;
            this.outofrange.Click += new System.EventHandler(this.outofrange_Click);
            // 
            // tekbutondakontrol
            // 
            this.tekbutondakontrol.Location = new System.Drawing.Point(16, 209);
            this.tekbutondakontrol.Name = "tekbutondakontrol";
            this.tekbutondakontrol.Size = new System.Drawing.Size(148, 23);
            this.tekbutondakontrol.TabIndex = 9;
            this.tekbutondakontrol.Text = "Tek Butonda Kontrol";
            this.tekbutondakontrol.UseVisualStyleBackColor = true;
            this.tekbutondakontrol.Click += new System.EventHandler(this.tekbutondakontrol_Click);
            // 
            // manuelex
            // 
            this.manuelex.Location = new System.Drawing.Point(16, 238);
            this.manuelex.Name = "manuelex";
            this.manuelex.Size = new System.Drawing.Size(148, 23);
            this.manuelex.TabIndex = 10;
            this.manuelex.Text = "Manuel Exception";
            this.manuelex.UseVisualStyleBackColor = true;
            this.manuelex.Click += new System.EventHandler(this.manuelex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 268);
            this.Controls.Add(this.manuelex);
            this.Controls.Add(this.tekbutondakontrol);
            this.Controls.Add(this.outofrange);
            this.Controls.Add(this.sbfinally);
            this.Controls.Add(this.sifirabolunme);
            this.Controls.Add(this.formatuyusmazligi);
            this.Controls.Add(this.sinirasimi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sinirasimi;
        private System.Windows.Forms.Button formatuyusmazligi;
        private System.Windows.Forms.Button sifirabolunme;
        private System.Windows.Forms.Button sbfinally;
        private System.Windows.Forms.Button outofrange;
        private System.Windows.Forms.Button tekbutondakontrol;
        private System.Windows.Forms.Button manuelex;
    }
}

