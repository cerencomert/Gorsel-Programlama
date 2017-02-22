namespace Örnek_3
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
            this.String.Location = new System.Drawing.Point(13, 39);
            this.String.Name = "String";
            this.String.Size = new System.Drawing.Size(100, 38);
            this.String.TabIndex = 1;
            this.String.Text = "String Yazdır";
            this.String.UseVisualStyleBackColor = true;
            this.String.Click += new System.EventHandler(this.String_Click);
            // 
            // Int
            // 
            this.Int.Location = new System.Drawing.Point(13, 85);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(100, 35);
            this.Int.TabIndex = 2;
            this.Int.Text = "Int Yazdır";
            this.Int.UseVisualStyleBackColor = true;
            this.Int.Click += new System.EventHandler(this.Int_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // strtoint
            // 
            this.strtoint.Location = new System.Drawing.Point(138, 67);
            this.strtoint.Name = "strtoint";
            this.strtoint.Size = new System.Drawing.Size(100, 24);
            this.strtoint.TabIndex = 5;
            this.strtoint.Text = "String To Int";
            this.strtoint.UseVisualStyleBackColor = true;
            this.strtoint.Click += new System.EventHandler(this.strtoint_Click);
            // 
            // intoint
            // 
            this.intoint.Location = new System.Drawing.Point(138, 97);
            this.intoint.Name = "intoint";
            this.intoint.Size = new System.Drawing.Size(100, 23);
            this.intoint.TabIndex = 6;
            this.intoint.Text = "Int To Int";
            this.intoint.UseVisualStyleBackColor = true;
            this.intoint.Click += new System.EventHandler(this.intoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

