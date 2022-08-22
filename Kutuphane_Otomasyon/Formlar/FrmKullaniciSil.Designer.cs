
namespace Kutuphane_Otomasyon.Formlar
{
    partial class FrmKullaniciSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciSilbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1876, 695);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullaniciSilbtn
            // 
            this.kullaniciSilbtn.BackColor = System.Drawing.Color.Crimson;
            this.kullaniciSilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSilbtn.Location = new System.Drawing.Point(68, 57);
            this.kullaniciSilbtn.Name = "kullaniciSilbtn";
            this.kullaniciSilbtn.Size = new System.Drawing.Size(282, 153);
            this.kullaniciSilbtn.TabIndex = 1;
            this.kullaniciSilbtn.Text = "Sil";
            this.kullaniciSilbtn.UseVisualStyleBackColor = false;
            this.kullaniciSilbtn.Click += new System.EventHandler(this.kullaniciSilbtn_Click);
            // 
            // FrmKullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1900, 962);
            this.Controls.Add(this.kullaniciSilbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKullaniciSil";
            this.Text = "FrmKullaniciSil";
            this.Load += new System.EventHandler(this.FrmKullaniciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kullaniciSilbtn;
    }
}