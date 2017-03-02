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
            this.inttoarray = new System.Windows.Forms.Button();
            this.stringtoarray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twodtoarray = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inttoarray
            // 
            this.inttoarray.Location = new System.Drawing.Point(12, 12);
            this.inttoarray.Name = "inttoarray";
            this.inttoarray.Size = new System.Drawing.Size(117, 60);
            this.inttoarray.TabIndex = 0;
            this.inttoarray.Text = "Integer/Arrays";
            this.inttoarray.UseVisualStyleBackColor = true;
            this.inttoarray.Click += new System.EventHandler(this.inttoarray_Click);
            // 
            // stringtoarray
            // 
            this.stringtoarray.Location = new System.Drawing.Point(135, 12);
            this.stringtoarray.Name = "stringtoarray";
            this.stringtoarray.Size = new System.Drawing.Size(117, 60);
            this.stringtoarray.TabIndex = 1;
            this.stringtoarray.Text = "String/Arrays";
            this.stringtoarray.UseVisualStyleBackColor = true;
            this.stringtoarray.Click += new System.EventHandler(this.stringtoarray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satır:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sütun:";
            // 
            // twodtoarray
            // 
            this.twodtoarray.Location = new System.Drawing.Point(135, 79);
            this.twodtoarray.Name = "twodtoarray";
            this.twodtoarray.Size = new System.Drawing.Size(117, 60);
            this.twodtoarray.TabIndex = 4;
            this.twodtoarray.Text = "2D/Array";
            this.twodtoarray.UseVisualStyleBackColor = true;
            this.twodtoarray.Click += new System.EventHandler(this.twodtoarray_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 175);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.twodtoarray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stringtoarray);
            this.Controls.Add(this.inttoarray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inttoarray;
        private System.Windows.Forms.Button stringtoarray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button twodtoarray;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

