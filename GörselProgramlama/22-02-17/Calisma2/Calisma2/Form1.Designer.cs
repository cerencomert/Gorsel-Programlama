namespace Calisma2
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
            this.String = new System.Windows.Forms.Button();
            this.Int = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.strtoint = new System.Windows.Forms.Button();
            this.intoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // String
            // 
            this.String.ForeColor = System.Drawing.Color.Maroon;
            this.String.Location = new System.Drawing.Point(13, 40);
            this.String.Name = "String";
            this.String.Size = new System.Drawing.Size(100, 34);
            this.String.TabIndex = 1;
            this.String.Text = "String Yazdır";
            this.String.UseVisualStyleBackColor = true;
            this.String.Click += new System.EventHandler(this.String_Click);
            // 
            // Int
            // 
            this.Int.ForeColor = System.Drawing.Color.Maroon;
            this.Int.Location = new System.Drawing.Point(13, 80);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(100, 39);
            this.Int.TabIndex = 2;
            this.Int.Text = "Int Yazdır";
            this.Int.UseVisualStyleBackColor = true;
            this.Int.Click += new System.EventHandler(this.Int_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // strtoint
            // 
            this.strtoint.ForeColor = System.Drawing.Color.Maroon;
            this.strtoint.Location = new System.Drawing.Point(132, 67);
            this.strtoint.Name = "strtoint";
            this.strtoint.Size = new System.Drawing.Size(100, 23);
            this.strtoint.TabIndex = 5;
            this.strtoint.Text = "String To Int";
            this.strtoint.UseVisualStyleBackColor = true;
            this.strtoint.Click += new System.EventHandler(this.strtoint_Click);
            // 
            // intoint
            // 
            this.intoint.ForeColor = System.Drawing.Color.Maroon;
            this.intoint.Location = new System.Drawing.Point(132, 96);
            this.intoint.Name = "intoint";
            this.intoint.Size = new System.Drawing.Size(100, 23);
            this.intoint.TabIndex = 6;
            this.intoint.Text = "Int To Int";
            this.intoint.UseVisualStyleBackColor = true;
            this.intoint.Click += new System.EventHandler(this.intoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intoint);
            this.Controls.Add(this.strtoint);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.String);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button String;
        private System.Windows.Forms.Button Int;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button strtoint;
        private System.Windows.Forms.Button intoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

