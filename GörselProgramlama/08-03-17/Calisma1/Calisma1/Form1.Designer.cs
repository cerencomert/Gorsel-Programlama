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
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.arraylist = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ScriptC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array List";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(22, 69);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(192, 56);
            this.add.TabIndex = 1;
            this.add.Text = "EKLE";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(22, 131);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(192, 56);
            this.substract.TabIndex = 2;
            this.substract.Text = "ÇIKAR";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // arraylist
            // 
            this.arraylist.Location = new System.Drawing.Point(22, 193);
            this.arraylist.Name = "arraylist";
            this.arraylist.Size = new System.Drawing.Size(192, 62);
            this.arraylist.TabIndex = 3;
            this.arraylist.Text = "KARIŞIK LİSTE";
            this.arraylist.UseVisualStyleBackColor = true;
            this.arraylist.Click += new System.EventHandler(this.arraylist_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(220, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 186);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 263);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.arraylist);
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
        private System.Windows.Forms.Button arraylist;
        private System.Windows.Forms.ListBox listBox1;
    }
}

