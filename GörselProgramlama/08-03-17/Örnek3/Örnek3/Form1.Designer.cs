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
            this.addrange = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.capacity = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.contains = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addrange
            // 
            this.addrange.Location = new System.Drawing.Point(13, 13);
            this.addrange.Name = "addrange";
            this.addrange.Size = new System.Drawing.Size(105, 95);
            this.addrange.TabIndex = 0;
            this.addrange.Text = "ADD RANGE";
            this.addrange.UseVisualStyleBackColor = true;
            this.addrange.Click += new System.EventHandler(this.addrange_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(125, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 199);
            this.listBox1.TabIndex = 1;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(12, 114);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(105, 98);
            this.capacity.TabIndex = 2;
            this.capacity.Text = "CAPACITY";
            this.capacity.UseVisualStyleBackColor = true;
            this.capacity.Click += new System.EventHandler(this.capacity_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 218);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 95);
            this.clear.TabIndex = 3;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // contains
            // 
            this.contains.Location = new System.Drawing.Point(125, 218);
            this.contains.Name = "contains";
            this.contains.Size = new System.Drawing.Size(105, 95);
            this.contains.TabIndex = 4;
            this.contains.Text = "CONTAINS";
            this.contains.UseVisualStyleBackColor = true;
            this.contains.Click += new System.EventHandler(this.contains_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(236, 218);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(115, 95);
            this.sort.TabIndex = 5;
            this.sort.Text = "SORT";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 322);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.contains);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addrange);
            this.Name = "Form1";
            this.Text = "ArrayList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addrange;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button capacity;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button contains;
        private System.Windows.Forms.Button sort;
    }
}

