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
            this.fill = new System.Windows.Forms.Button();
            this.itemcount = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fill.Location = new System.Drawing.Point(13, 13);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(124, 69);
            this.fill.TabIndex = 0;
            this.fill.Text = "DOLDUR";
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // itemcount
            // 
            this.itemcount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemcount.Location = new System.Drawing.Point(13, 88);
            this.itemcount.Name = "itemcount";
            this.itemcount.Size = new System.Drawing.Size(124, 72);
            this.itemcount.TabIndex = 1;
            this.itemcount.Text = "ELEMAN SAYISI";
            this.itemcount.UseVisualStyleBackColor = false;
            this.itemcount.Click += new System.EventHandler(this.itemcount_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(144, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.itemcount);
            this.Controls.Add(this.fill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button itemcount;
        private System.Windows.Forms.ListBox listBox1;
    }
}

