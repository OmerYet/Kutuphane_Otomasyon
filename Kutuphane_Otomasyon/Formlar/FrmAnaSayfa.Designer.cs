
namespace Kutuphane_Otomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personelAdGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelSifreGiristxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelGirisbtn = new System.Windows.Forms.Button();
            this.personelGirisPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelGirisPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // personelAdGiristxt
            // 
            this.personelAdGiristxt.Location = new System.Drawing.Point(128, 211);
            this.personelAdGiristxt.Name = "personelAdGiristxt";
            this.personelAdGiristxt.Size = new System.Drawing.Size(251, 22);
            this.personelAdGiristxt.TabIndex = 0;
            this.personelAdGiristxt.TextChanged += new System.EventHandler(this.personelAdGiristxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            // 
            // personelSifreGiristxt
            // 
            this.personelSifreGiristxt.Location = new System.Drawing.Point(128, 264);
            this.personelSifreGiristxt.Name = "personelSifreGiristxt";
            this.personelSifreGiristxt.Size = new System.Drawing.Size(251, 22);
            this.personelSifreGiristxt.TabIndex = 2;
            this.personelSifreGiristxt.TextChanged += new System.EventHandler(this.personelSifreGiristxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Şifre:";
            // 
            // personelGirisbtn
            // 
            this.personelGirisbtn.BackColor = System.Drawing.Color.Azure;
            this.personelGirisbtn.Location = new System.Drawing.Point(128, 312);
            this.personelGirisbtn.Name = "personelGirisbtn";
            this.personelGirisbtn.Size = new System.Drawing.Size(251, 41);
            this.personelGirisbtn.TabIndex = 4;
            this.personelGirisbtn.Text = "Giriş";
            this.personelGirisbtn.UseVisualStyleBackColor = false;
            this.personelGirisbtn.Click += new System.EventHandler(this.personelGirisbtn_Click);
            // 
            // personelGirisPBox
            // 
            this.personelGirisPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personelGirisPBox.Image = ((System.Drawing.Image)(resources.GetObject("personelGirisPBox.Image")));
            this.personelGirisPBox.Location = new System.Drawing.Point(128, 27);
            this.personelGirisPBox.Name = "personelGirisPBox";
            this.personelGirisPBox.Size = new System.Drawing.Size(174, 158);
            this.personelGirisPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personelGirisPBox.TabIndex = 5;
            this.personelGirisPBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(416, 389);
            this.Controls.Add(this.personelGirisPBox);
            this.Controls.Add(this.personelGirisbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personelSifreGiristxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelAdGiristxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personelGirisPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personelAdGiristxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personelSifreGiristxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button personelGirisbtn;
        private System.Windows.Forms.PictureBox personelGirisPBox;
    }
}

