namespace Projectrecipe
{
    partial class TarifEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifEkle));
            this.yenitarifekle = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // yenitarifekle
            // 
            this.yenitarifekle.AutoSize = true;
            this.yenitarifekle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yenitarifekle.Depth = 0;
            this.yenitarifekle.ForeColor = System.Drawing.Color.BurlyWood;
            this.yenitarifekle.Image = ((System.Drawing.Image)(resources.GetObject("yenitarifekle.Image")));
            this.yenitarifekle.Location = new System.Drawing.Point(12, 69);
            this.yenitarifekle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.yenitarifekle.MouseState = MaterialSkin.MouseState.HOVER;
            this.yenitarifekle.Name = "yenitarifekle";
            this.yenitarifekle.Primary = false;
            this.yenitarifekle.Size = new System.Drawing.Size(73, 36);
            this.yenitarifekle.TabIndex = 16;
            this.yenitarifekle.Text = "GERİ DÖN";
            this.yenitarifekle.UseVisualStyleBackColor = true;
            this.yenitarifekle.Click += new System.EventHandler(this.yenitarifekle_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.BurlyWood;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 114);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1427, 10);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TarifEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 900);
            this.Controls.Add(this.yenitarifekle);
            this.Controls.Add(this.materialDivider1);
            this.Name = "TarifEkle";
            this.Text = "ZEYTİN DALI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TarifEkle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton yenitarifekle;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}