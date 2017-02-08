namespace Calisma1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Gun = new System.Windows.Forms.Button();
            this.Gunyazi = new System.Windows.Forms.Label();
            this.Ornek = new System.Windows.Forms.Button();
            this.Ornekyazi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.evet = new System.Windows.Forms.RadioButton();
            this.hayir = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Sans 500", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(264, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışmam var mı?";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 69);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Gun
            // 
            this.Gun.BackColor = System.Drawing.Color.Honeydew;
            this.Gun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gun.Font = new System.Drawing.Font("Museo Sans 500", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gun.ForeColor = System.Drawing.Color.Teal;
            this.Gun.Location = new System.Drawing.Point(391, 69);
            this.Gun.Name = "Gun";
            this.Gun.Size = new System.Drawing.Size(204, 54);
            this.Gun.TabIndex = 5;
            this.Gun.Text = "Günü kontrol et";
            this.Gun.UseVisualStyleBackColor = false;
            this.Gun.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gunyazi
            // 
            this.Gunyazi.AutoSize = true;
            this.Gunyazi.Font = new System.Drawing.Font("Museo Sans 500", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gunyazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gunyazi.Location = new System.Drawing.Point(395, 143);
            this.Gunyazi.Name = "Gunyazi";
            this.Gunyazi.Size = new System.Drawing.Size(43, 16);
            this.Gunyazi.TabIndex = 6;
            this.Gunyazi.Text = "label2";
            // 
            // Ornek
            // 
            this.Ornek.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Ornek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ornek.Font = new System.Drawing.Font("Museo Sans 500", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ornek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ornek.Location = new System.Drawing.Point(391, 177);
            this.Ornek.Name = "Ornek";
            this.Ornek.Size = new System.Drawing.Size(204, 54);
            this.Ornek.TabIndex = 7;
            this.Ornek.Text = "Örnek sayısı seç";
            this.Ornek.UseVisualStyleBackColor = false;
            this.Ornek.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ornekyazi
            // 
            this.Ornekyazi.AutoSize = true;
            this.Ornekyazi.Font = new System.Drawing.Font("Museo Sans 500", 9.74F, System.Drawing.FontStyle.Underline);
            this.Ornekyazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ornekyazi.Location = new System.Drawing.Point(395, 259);
            this.Ornekyazi.Name = "Ornekyazi";
            this.Ornekyazi.Size = new System.Drawing.Size(43, 16);
            this.Ornekyazi.TabIndex = 8;
            this.Ornekyazi.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Museo Sans 500", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(264, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Örnekler bitti mi?";
            // 
            // evet
            // 
            this.evet.AutoSize = true;
            this.evet.Location = new System.Drawing.Point(268, 369);
            this.evet.Name = "evet";
            this.evet.Size = new System.Drawing.Size(47, 17);
            this.evet.TabIndex = 10;
            this.evet.TabStop = true;
            this.evet.Text = "Evet";
            this.evet.UseVisualStyleBackColor = true;
            // 
            // hayir
            // 
            this.hayir.AutoSize = true;
            this.hayir.Location = new System.Drawing.Point(387, 369);
            this.hayir.Name = "hayir";
            this.hayir.Size = new System.Drawing.Size(49, 17);
            this.hayir.TabIndex = 11;
            this.hayir.TabStop = true;
            this.hayir.Text = "Hayır";
            this.hayir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Museo Sans 500", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(286, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(713, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hayir);
            this.Controls.Add(this.evet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ornekyazi);
            this.Controls.Add(this.Ornek);
            this.Controls.Add(this.Gunyazi);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Gun;
        private System.Windows.Forms.Label Gunyazi;
        private System.Windows.Forms.Button Ornek;
        private System.Windows.Forms.Label Ornekyazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton evet;
        private System.Windows.Forms.RadioButton hayir;
        private System.Windows.Forms.Button button1;
    }
}

