
namespace Kutuphane_Otomasyon.Formlar
{
    partial class FrmKaynakEkle
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
            this.kaynakKaydetbtn = new System.Windows.Forms.Button();
            this.kaynakYayincitxt = new System.Windows.Forms.TextBox();
            this.kaynakYazartxt = new System.Windows.Forms.TextBox();
            this.kaynakTurtxt = new System.Windows.Forms.TextBox();
            this.kaynakAdtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kaynakBasimTarihidate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1592, 719);
            this.dataGridView1.TabIndex = 26;
            // 
            // kaynakKaydetbtn
            // 
            this.kaynakKaydetbtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.kaynakKaydetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakKaydetbtn.Location = new System.Drawing.Point(41, 347);
            this.kaynakKaydetbtn.Name = "kaynakKaydetbtn";
            this.kaynakKaydetbtn.Size = new System.Drawing.Size(286, 46);
            this.kaynakKaydetbtn.TabIndex = 51;
            this.kaynakKaydetbtn.Text = "Kaydet";
            this.kaynakKaydetbtn.UseVisualStyleBackColor = false;
            this.kaynakKaydetbtn.Click += new System.EventHandler(this.kaynakKaydetbtn_Click);
            // 
            // kaynakYayincitxt
            // 
            this.kaynakYayincitxt.Location = new System.Drawing.Point(133, 259);
            this.kaynakYayincitxt.Name = "kaynakYayincitxt";
            this.kaynakYayincitxt.Size = new System.Drawing.Size(194, 22);
            this.kaynakYayincitxt.TabIndex = 43;
            // 
            // kaynakYazartxt
            // 
            this.kaynakYazartxt.Location = new System.Drawing.Point(133, 189);
            this.kaynakYazartxt.Name = "kaynakYazartxt";
            this.kaynakYazartxt.Size = new System.Drawing.Size(194, 22);
            this.kaynakYazartxt.TabIndex = 41;
            // 
            // kaynakTurtxt
            // 
            this.kaynakTurtxt.Location = new System.Drawing.Point(133, 154);
            this.kaynakTurtxt.Name = "kaynakTurtxt";
            this.kaynakTurtxt.Size = new System.Drawing.Size(194, 22);
            this.kaynakTurtxt.TabIndex = 40;
            // 
            // kaynakAdtxt
            // 
            this.kaynakAdtxt.Location = new System.Drawing.Point(133, 120);
            this.kaynakAdtxt.Name = "kaynakAdtxt";
            this.kaynakAdtxt.Size = new System.Drawing.Size(194, 22);
            this.kaynakAdtxt.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Basım Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Yayıncı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tür:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad: ";
            // 
            // kaynakBasimTarihidate
            // 
            this.kaynakBasimTarihidate.Location = new System.Drawing.Point(133, 296);
            this.kaynakBasimTarihidate.Name = "kaynakBasimTarihidate";
            this.kaynakBasimTarihidate.Size = new System.Drawing.Size(194, 22);
            this.kaynakBasimTarihidate.TabIndex = 53;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 224);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(194, 22);
            this.numericUpDown1.TabIndex = 54;
            // 
            // FrmKaynakEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1994, 805);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.kaynakBasimTarihidate);
            this.Controls.Add(this.kaynakKaydetbtn);
            this.Controls.Add(this.kaynakYayincitxt);
            this.Controls.Add(this.kaynakYazartxt);
            this.Controls.Add(this.kaynakTurtxt);
            this.Controls.Add(this.kaynakAdtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKaynakEkle";
            this.Text = "FrmKaynakEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKaynakEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kaynakKaydetbtn;
        private System.Windows.Forms.TextBox kaynakYayincitxt;
        private System.Windows.Forms.TextBox kaynakYazartxt;
        private System.Windows.Forms.TextBox kaynakTurtxt;
        private System.Windows.Forms.TextBox kaynakAdtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker kaynakBasimTarihidate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}