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
            this.Strct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Strct
            // 
            this.Strct.Location = new System.Drawing.Point(12, 12);
            this.Strct.Name = "Strct";
            this.Strct.Size = new System.Drawing.Size(152, 53);
            this.Strct.TabIndex = 0;
            this.Strct.Text = "Struct";
            this.Strct.UseVisualStyleBackColor = true;
            this.Strct.Click += new System.EventHandler(this.Strct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 77);
            this.Controls.Add(this.Strct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Strct;
    }
}

