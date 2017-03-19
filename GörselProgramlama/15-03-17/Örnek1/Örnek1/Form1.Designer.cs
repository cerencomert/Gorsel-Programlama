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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.show = new System.Windows.Forms.Button();
            this.showinmbox = new System.Windows.Forms.Button();
            this.showinmbox2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 40);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 37);
            this.add.TabIndex = 1;
            this.add.Text = "EKLE";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(132, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 108);
            this.listBox1.TabIndex = 2;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(13, 83);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(100, 38);
            this.show.TabIndex = 3;
            this.show.Text = "YAZDIR";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // showinmbox
            // 
            this.showinmbox.Location = new System.Drawing.Point(13, 128);
            this.showinmbox.Name = "showinmbox";
            this.showinmbox.Size = new System.Drawing.Size(243, 49);
            this.showinmbox.TabIndex = 4;
            this.showinmbox.Text = "MESSAGEBOX\'A YAZDIR";
            this.showinmbox.UseVisualStyleBackColor = true;
            this.showinmbox.Click += new System.EventHandler(this.showinmbox_Click);
            // 
            // showinmbox2
            // 
            this.showinmbox2.Location = new System.Drawing.Point(13, 183);
            this.showinmbox2.Name = "showinmbox2";
            this.showinmbox2.Size = new System.Drawing.Size(243, 49);
            this.showinmbox2.TabIndex = 5;
            this.showinmbox2.Text = "MESSAGEBOX\'A YAZDIR (2)";
            this.showinmbox2.UseVisualStyleBackColor = true;
            this.showinmbox2.Click += new System.EventHandler(this.showinmbox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 249);
            this.Controls.Add(this.showinmbox2);
            this.Controls.Add(this.showinmbox);
            this.Controls.Add(this.show);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button showinmbox;
        private System.Windows.Forms.Button showinmbox2;
    }
}

