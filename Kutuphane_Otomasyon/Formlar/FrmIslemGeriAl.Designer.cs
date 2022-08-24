
namespace Kutuphane_Otomasyon.Formlar
{
    partial class FrmIslemGeriAl
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
            this.geriAlbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1970, 615);
            this.dataGridView1.TabIndex = 0;
            // 
            // geriAlbtn
            // 
            this.geriAlbtn.BackColor = System.Drawing.Color.Orange;
            this.geriAlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriAlbtn.Location = new System.Drawing.Point(12, 54);
            this.geriAlbtn.Name = "geriAlbtn";
            this.geriAlbtn.Size = new System.Drawing.Size(168, 77);
            this.geriAlbtn.TabIndex = 1;
            this.geriAlbtn.Text = "Geri Al";
            this.geriAlbtn.UseVisualStyleBackColor = false;
            this.geriAlbtn.Click += new System.EventHandler(this.geriAlbtn_Click);
            // 
            // FrmIslemGeriAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1994, 805);
            this.Controls.Add(this.geriAlbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIslemGeriAl";
            this.Text = "FrmIslemGeriAl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIslemGeriAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geriAlbtn;
    }
}