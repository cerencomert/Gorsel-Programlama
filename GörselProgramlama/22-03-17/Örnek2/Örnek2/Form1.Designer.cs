namespace Örnek2
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
            this.falseadd = new System.Windows.Forms.Button();
            this.hatayakalama = new System.Windows.Forms.Button();
            this.hatagosterme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // falseadd
            // 
            this.falseadd.Location = new System.Drawing.Point(16, 77);
            this.falseadd.Name = "falseadd";
            this.falseadd.Size = new System.Drawing.Size(162, 61);
            this.falseadd.TabIndex = 4;
            this.falseadd.Text = "HATALI TOPLAMA";
            this.falseadd.UseVisualStyleBackColor = true;
            this.falseadd.Click += new System.EventHandler(this.falseadd_Click);
            // 
            // hatayakalama
            // 
            this.hatayakalama.Location = new System.Drawing.Point(16, 144);
            this.hatayakalama.Name = "hatayakalama";
            this.hatayakalama.Size = new System.Drawing.Size(72, 50);
            this.hatayakalama.TabIndex = 5;
            this.hatayakalama.Text = "Hata Yakalama";
            this.hatayakalama.UseVisualStyleBackColor = true;
            this.hatayakalama.Click += new System.EventHandler(this.hatayakalama_Click);
            // 
            // hatagosterme
            // 
            this.hatagosterme.Location = new System.Drawing.Point(104, 144);
            this.hatagosterme.Name = "hatagosterme";
            this.hatagosterme.Size = new System.Drawing.Size(74, 50);
            this.hatagosterme.TabIndex = 6;
            this.hatagosterme.Text = "Hatayı Gösterme";
            this.hatagosterme.UseVisualStyleBackColor = true;
            this.hatagosterme.Click += new System.EventHandler(this.hatagosterme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 214);
            this.Controls.Add(this.hatagosterme);
            this.Controls.Add(this.hatayakalama);
            this.Controls.Add(this.falseadd);
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
        private System.Windows.Forms.Button falseadd;
        private System.Windows.Forms.Button hatayakalama;
        private System.Windows.Forms.Button hatagosterme;
    }
}

