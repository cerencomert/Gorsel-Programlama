namespace Örnek4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.doldur = new System.Windows.Forms.Button();
            this.goster = new System.Windows.Forms.Button();
            this.kontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(116, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 134);
            this.listBox1.TabIndex = 0;
            // 
            // doldur
            // 
            this.doldur.Location = new System.Drawing.Point(12, 12);
            this.doldur.Name = "doldur";
            this.doldur.Size = new System.Drawing.Size(98, 42);
            this.doldur.TabIndex = 1;
            this.doldur.Text = "Doldur";
            this.doldur.UseVisualStyleBackColor = true;
            this.doldur.Click += new System.EventHandler(this.doldur_Click);
            // 
            // goster
            // 
            this.goster.Location = new System.Drawing.Point(12, 60);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(98, 42);
            this.goster.TabIndex = 2;
            this.goster.Text = "Ekranda Göster";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // kontrol
            // 
            this.kontrol.Location = new System.Drawing.Point(12, 108);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(98, 38);
            this.kontrol.TabIndex = 3;
            this.kontrol.Text = "Kontrol Et";
            this.kontrol.UseVisualStyleBackColor = true;
            this.kontrol.Click += new System.EventHandler(this.kontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 168);
            this.Controls.Add(this.kontrol);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.doldur);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button doldur;
        private System.Windows.Forms.Button goster;
        private System.Windows.Forms.Button kontrol;
    }
}

