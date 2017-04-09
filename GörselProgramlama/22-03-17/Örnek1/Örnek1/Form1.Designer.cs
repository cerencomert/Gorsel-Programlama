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
            this.errorcolor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.debugmode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorcolor
            // 
            this.errorcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorcolor.Location = new System.Drawing.Point(13, 13);
            this.errorcolor.Name = "errorcolor";
            this.errorcolor.Size = new System.Drawing.Size(407, 99);
            this.errorcolor.TabIndex = 0;
            this.errorcolor.Text = "HATA RENKLERİ";
            this.errorcolor.UseVisualStyleBackColor = true;
            this.errorcolor.Click += new System.EventHandler(this.errorcolor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 77);
            this.textBox1.TabIndex = 1;
            // 
            // debugmode
            // 
            this.debugmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debugmode.Location = new System.Drawing.Point(216, 119);
            this.debugmode.Name = "debugmode";
            this.debugmode.Size = new System.Drawing.Size(204, 77);
            this.debugmode.TabIndex = 2;
            this.debugmode.Text = "HATA AYIKLAMA";
            this.debugmode.UseVisualStyleBackColor = true;
            this.debugmode.Click += new System.EventHandler(this.debugmode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 212);
            this.Controls.Add(this.debugmode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.errorcolor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button errorcolor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button debugmode;
    }
}

