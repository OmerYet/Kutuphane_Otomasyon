
namespace Kutuphane_Otomasyon.Formlar
{
    partial class FrmKaynakSil
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
            this.kaynakSilbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1970, 670);
            this.dataGridView1.TabIndex = 1;
            // 
            // kaynakSilbtn
            // 
            this.kaynakSilbtn.BackColor = System.Drawing.Color.Crimson;
            this.kaynakSilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakSilbtn.Location = new System.Drawing.Point(12, 12);
            this.kaynakSilbtn.Name = "kaynakSilbtn";
            this.kaynakSilbtn.Size = new System.Drawing.Size(166, 105);
            this.kaynakSilbtn.TabIndex = 2;
            this.kaynakSilbtn.Text = "Sil";
            this.kaynakSilbtn.UseVisualStyleBackColor = false;
            this.kaynakSilbtn.Click += new System.EventHandler(this.kaynakSilbtn_Click);
            // 
            // FrmKaynakSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1994, 805);
            this.Controls.Add(this.kaynakSilbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKaynakSil";
            this.Text = "FrmKaynakSil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKaynakSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kaynakSilbtn;
    }
}