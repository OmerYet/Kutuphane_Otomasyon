
namespace Kutuphane_Otomasyon.Formlar
{
    partial class FrmKullaniciGuncelle
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
            this.kullaniciKutuphanetxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kullaniciGuncellebtn = new System.Windows.Forms.Button();
            this.radioK = new System.Windows.Forms.RadioButton();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.kullaniciFavTurtxt = new System.Windows.Forms.TextBox();
            this.kullaniciSayfaSayisitxt = new System.Windows.Forms.TextBox();
            this.kullaniciKitapSayisitxt = new System.Windows.Forms.TextBox();
            this.kullaniciCezatxt = new System.Windows.Forms.TextBox();
            this.kullaniciMailtxt = new System.Windows.Forms.TextBox();
            this.kullaniciTelefontxt = new System.Windows.Forms.TextBox();
            this.kullaniciTctxt = new System.Windows.Forms.TextBox();
            this.kullaniciYastxt = new System.Windows.Forms.TextBox();
            this.kullaniciSoyadtxt = new System.Windows.Forms.TextBox();
            this.kullaniciAdtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1592, 717);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kullaniciKutuphanetxt
            // 
            this.kullaniciKutuphanetxt.Location = new System.Drawing.Point(140, 444);
            this.kullaniciKutuphanetxt.Name = "kullaniciKutuphanetxt";
            this.kullaniciKutuphanetxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciKutuphanetxt.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Location = new System.Drawing.Point(31, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Kütüphane No:";
            // 
            // kullaniciGuncellebtn
            // 
            this.kullaniciGuncellebtn.BackColor = System.Drawing.Color.Orange;
            this.kullaniciGuncellebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciGuncellebtn.Location = new System.Drawing.Point(48, 494);
            this.kullaniciGuncellebtn.Name = "kullaniciGuncellebtn";
            this.kullaniciGuncellebtn.Size = new System.Drawing.Size(286, 46);
            this.kullaniciGuncellebtn.TabIndex = 51;
            this.kullaniciGuncellebtn.Text = "Güncelle";
            this.kullaniciGuncellebtn.UseVisualStyleBackColor = false;
            this.kullaniciGuncellebtn.Click += new System.EventHandler(this.kullaniciGuncellebtn_Click);
            // 
            // radioK
            // 
            this.radioK.AutoSize = true;
            this.radioK.Location = new System.Drawing.Point(255, 142);
            this.radioK.Name = "radioK";
            this.radioK.Size = new System.Drawing.Size(38, 21);
            this.radioK.TabIndex = 50;
            this.radioK.TabStop = true;
            this.radioK.Text = "K";
            this.radioK.UseVisualStyleBackColor = true;
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Location = new System.Drawing.Point(173, 142);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(38, 21);
            this.radioE.TabIndex = 49;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // kullaniciFavTurtxt
            // 
            this.kullaniciFavTurtxt.Location = new System.Drawing.Point(140, 408);
            this.kullaniciFavTurtxt.Name = "kullaniciFavTurtxt";
            this.kullaniciFavTurtxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciFavTurtxt.TabIndex = 48;
            // 
            // kullaniciSayfaSayisitxt
            // 
            this.kullaniciSayfaSayisitxt.Location = new System.Drawing.Point(140, 374);
            this.kullaniciSayfaSayisitxt.Name = "kullaniciSayfaSayisitxt";
            this.kullaniciSayfaSayisitxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciSayfaSayisitxt.TabIndex = 47;
            // 
            // kullaniciKitapSayisitxt
            // 
            this.kullaniciKitapSayisitxt.Location = new System.Drawing.Point(140, 339);
            this.kullaniciKitapSayisitxt.Name = "kullaniciKitapSayisitxt";
            this.kullaniciKitapSayisitxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciKitapSayisitxt.TabIndex = 46;
            // 
            // kullaniciCezatxt
            // 
            this.kullaniciCezatxt.Location = new System.Drawing.Point(140, 306);
            this.kullaniciCezatxt.Name = "kullaniciCezatxt";
            this.kullaniciCezatxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciCezatxt.TabIndex = 45;
            // 
            // kullaniciMailtxt
            // 
            this.kullaniciMailtxt.Location = new System.Drawing.Point(140, 274);
            this.kullaniciMailtxt.Name = "kullaniciMailtxt";
            this.kullaniciMailtxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciMailtxt.TabIndex = 44;
            // 
            // kullaniciTelefontxt
            // 
            this.kullaniciTelefontxt.Location = new System.Drawing.Point(140, 243);
            this.kullaniciTelefontxt.Name = "kullaniciTelefontxt";
            this.kullaniciTelefontxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciTelefontxt.TabIndex = 43;
            // 
            // kullaniciTctxt
            // 
            this.kullaniciTctxt.Location = new System.Drawing.Point(140, 209);
            this.kullaniciTctxt.Name = "kullaniciTctxt";
            this.kullaniciTctxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciTctxt.TabIndex = 42;
            // 
            // kullaniciYastxt
            // 
            this.kullaniciYastxt.Location = new System.Drawing.Point(140, 176);
            this.kullaniciYastxt.Name = "kullaniciYastxt";
            this.kullaniciYastxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciYastxt.TabIndex = 41;
            // 
            // kullaniciSoyadtxt
            // 
            this.kullaniciSoyadtxt.Location = new System.Drawing.Point(140, 109);
            this.kullaniciSoyadtxt.Name = "kullaniciSoyadtxt";
            this.kullaniciSoyadtxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciSoyadtxt.TabIndex = 40;
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Location = new System.Drawing.Point(140, 76);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(194, 22);
            this.kullaniciAdtxt.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Mail Adresi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Favori Türü:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Sayfa Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Kitap Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Ceza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad: ";
            // 
            // FrmKullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1994, 805);
            this.Controls.Add(this.kullaniciKutuphanetxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.kullaniciGuncellebtn);
            this.Controls.Add(this.radioK);
            this.Controls.Add(this.radioE);
            this.Controls.Add(this.kullaniciFavTurtxt);
            this.Controls.Add(this.kullaniciSayfaSayisitxt);
            this.Controls.Add(this.kullaniciKitapSayisitxt);
            this.Controls.Add(this.kullaniciCezatxt);
            this.Controls.Add(this.kullaniciMailtxt);
            this.Controls.Add(this.kullaniciTelefontxt);
            this.Controls.Add(this.kullaniciTctxt);
            this.Controls.Add(this.kullaniciYastxt);
            this.Controls.Add(this.kullaniciSoyadtxt);
            this.Controls.Add(this.kullaniciAdtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKullaniciGuncelle";
            this.Text = "FrmKullaniciGuncelle";
            this.Load += new System.EventHandler(this.FrmKullaniciGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kullaniciKutuphanetxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button kullaniciGuncellebtn;
        private System.Windows.Forms.RadioButton radioK;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.TextBox kullaniciFavTurtxt;
        private System.Windows.Forms.TextBox kullaniciSayfaSayisitxt;
        private System.Windows.Forms.TextBox kullaniciKitapSayisitxt;
        private System.Windows.Forms.TextBox kullaniciCezatxt;
        private System.Windows.Forms.TextBox kullaniciMailtxt;
        private System.Windows.Forms.TextBox kullaniciTelefontxt;
        private System.Windows.Forms.TextBox kullaniciTctxt;
        private System.Windows.Forms.TextBox kullaniciYastxt;
        private System.Windows.Forms.TextBox kullaniciSoyadtxt;
        private System.Windows.Forms.TextBox kullaniciAdtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}