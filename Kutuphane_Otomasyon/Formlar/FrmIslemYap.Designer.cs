
namespace Kutuphane_Otomasyon.Formlar
{
    partial class FrmIslemYap
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
            this.label1 = new System.Windows.Forms.Label();
            this.islemyTcBultxt = new System.Windows.Forms.TextBox();
            this.islemyapBulbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.islemyAdAramatxt = new System.Windows.Forms.TextBox();
            this.islemyKitapIslembtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1970, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullacının Tc\'sini giriniz: ";
            // 
            // islemyTcBultxt
            // 
            this.islemyTcBultxt.Location = new System.Drawing.Point(188, 47);
            this.islemyTcBultxt.Name = "islemyTcBultxt";
            this.islemyTcBultxt.Size = new System.Drawing.Size(221, 22);
            this.islemyTcBultxt.TabIndex = 2;
            // 
            // islemyapBulbtn
            // 
            this.islemyapBulbtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.islemyapBulbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemyapBulbtn.Location = new System.Drawing.Point(24, 95);
            this.islemyapBulbtn.Name = "islemyapBulbtn";
            this.islemyapBulbtn.Size = new System.Drawing.Size(158, 30);
            this.islemyapBulbtn.TabIndex = 3;
            this.islemyapBulbtn.Text = "BUL";
            this.islemyapBulbtn.UseVisualStyleBackColor = false;
            this.islemyapBulbtn.Click += new System.EventHandler(this.islemyapBulbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(488, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1494, 257);
            this.dataGridView2.TabIndex = 5;
            // 
            // islemyAdAramatxt
            // 
            this.islemyAdAramatxt.Location = new System.Drawing.Point(488, 47);
            this.islemyAdAramatxt.Name = "islemyAdAramatxt";
            this.islemyAdAramatxt.Size = new System.Drawing.Size(511, 22);
            this.islemyAdAramatxt.TabIndex = 6;
            this.islemyAdAramatxt.TextChanged += new System.EventHandler(this.islemyAdAramatxt_TextChanged);
            // 
            // islemyKitapIslembtn
            // 
            this.islemyKitapIslembtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.islemyKitapIslembtn.Location = new System.Drawing.Point(102, 237);
            this.islemyKitapIslembtn.Name = "islemyKitapIslembtn";
            this.islemyKitapIslembtn.Size = new System.Drawing.Size(221, 64);
            this.islemyKitapIslembtn.TabIndex = 7;
            this.islemyKitapIslembtn.Text = "Kitabı İşleme Sok";
            this.islemyKitapIslembtn.UseVisualStyleBackColor = false;
            this.islemyKitapIslembtn.Click += new System.EventHandler(this.islemyKitapIslembtn_Click);
            // 
            // FrmIslemYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1994, 805);
            this.Controls.Add(this.islemyKitapIslembtn);
            this.Controls.Add(this.islemyAdAramatxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.islemyapBulbtn);
            this.Controls.Add(this.islemyTcBultxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIslemYap";
            this.Text = "FrmIslemYap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIslemYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox islemyTcBultxt;
        private System.Windows.Forms.Button islemyapBulbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox islemyAdAramatxt;
        private System.Windows.Forms.Button islemyKitapIslembtn;
    }
}