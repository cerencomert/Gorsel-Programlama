namespace WindowsFormsApplication1
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
            this.geri = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ileri = new System.Windows.Forms.Button();
            this.git = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.yenile = new System.Windows.Forms.Button();
            this.anasayfa = new System.Windows.Forms.Button();
            this.kaynak = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.yazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(6, 11);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 0;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.button1_Click);
            this.geri.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 84);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1188, 591);
            this.webBrowser1.TabIndex = 1;
            // 
            // ileri
            // 
            this.ileri.Location = new System.Drawing.Point(87, 11);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(75, 23);
            this.ileri.TabIndex = 2;
            this.ileri.Text = "İleri";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // git
            // 
            this.git.Location = new System.Drawing.Point(246, 11);
            this.git.Name = "git";
            this.git.Size = new System.Drawing.Size(75, 23);
            this.git.TabIndex = 3;
            this.git.Text = "Git";
            this.git.UseVisualStyleBackColor = true;
            this.git.Click += new System.EventHandler(this.git_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(327, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(867, 22);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(168, 11);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(75, 23);
            this.yenile.TabIndex = 5;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.Location = new System.Drawing.Point(6, 40);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(75, 23);
            this.anasayfa.TabIndex = 6;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // kaynak
            // 
            this.kaynak.Location = new System.Drawing.Point(88, 40);
            this.kaynak.Name = "kaynak";
            this.kaynak.Size = new System.Drawing.Size(75, 23);
            this.kaynak.TabIndex = 7;
            this.kaynak.Text = "Kaynak";
            this.kaynak.UseVisualStyleBackColor = true;
            this.kaynak.Click += new System.EventHandler(this.kaynak_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 70);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1188, 605);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            this.richTextBox2.DoubleClick += new System.EventHandler(this.richTextBox2_DoubleClick);
            // 
            // yazdir
            // 
            this.yazdir.Location = new System.Drawing.Point(168, 40);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(75, 23);
            this.yazdir.TabIndex = 9;
            this.yazdir.Text = "Yazdır";
            this.yazdir.UseVisualStyleBackColor = true;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 774);
            this.Controls.Add(this.yazdir);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.kaynak);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.git);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.geri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button git;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Button kaynak;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button yazdir;
    }
}

