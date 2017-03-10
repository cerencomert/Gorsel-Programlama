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
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.arry = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArrayLists";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 48);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 30);
            this.add.TabIndex = 1;
            this.add.Text = "EKLE";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(12, 103);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(95, 30);
            this.substract.TabIndex = 2;
            this.substract.Text = "ÇIKAR";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // arry
            // 
            this.arry.Location = new System.Drawing.Point(12, 160);
            this.arry.Name = "arry";
            this.arry.Size = new System.Drawing.Size(95, 30);
            this.arry.TabIndex = 3;
            this.arry.Text = "KARIŞIK DİZİ";
            this.arry.UseVisualStyleBackColor = true;
            this.arry.Click += new System.EventHandler(this.arry_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(133, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 215);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.arry);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button arry;
        private System.Windows.Forms.ListBox listBox1;
    }
}

