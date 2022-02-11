
namespace KaloriDeneme_1111
{
    partial class UyeKayit_4
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
            this.txtEpostaGir = new System.Windows.Forms.TextBox();
            this.txtSifreGir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHesabimiSil = new System.Windows.Forms.CheckBox();
            this.lblSifremiUnuttum = new System.Windows.Forms.Label();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnHesabimiSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEpostaGir
            // 
            this.txtEpostaGir.Location = new System.Drawing.Point(9, 52);
            this.txtEpostaGir.Margin = new System.Windows.Forms.Padding(2);
            this.txtEpostaGir.Name = "txtEpostaGir";
            this.txtEpostaGir.Size = new System.Drawing.Size(234, 20);
            this.txtEpostaGir.TabIndex = 0;
            this.txtEpostaGir.Text = "E-Posta Adresinizi Giriniz ";
            this.txtEpostaGir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifreGir
            // 
            this.txtSifreGir.Location = new System.Drawing.Point(9, 76);
            this.txtSifreGir.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifreGir.Name = "txtSifreGir";
            this.txtSifreGir.Size = new System.Drawing.Size(234, 20);
            this.txtSifreGir.TabIndex = 1;
            this.txtSifreGir.Text = "Şifrenizi Giriniz";
            this.txtSifreGir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(44, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hesabımı Silmek İstiyorum:";
            // 
            // chkHesabimiSil
            // 
            this.chkHesabimiSil.AutoSize = true;
            this.chkHesabimiSil.Location = new System.Drawing.Point(184, 240);
            this.chkHesabimiSil.Margin = new System.Windows.Forms.Padding(2);
            this.chkHesabimiSil.Name = "chkHesabimiSil";
            this.chkHesabimiSil.Size = new System.Drawing.Size(15, 14);
            this.chkHesabimiSil.TabIndex = 5;
            this.chkHesabimiSil.UseVisualStyleBackColor = true;
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifremiUnuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(71, 110);
            this.lblSifremiUnuttum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(128, 24);
            this.lblSifremiUnuttum.TabIndex = 29;
            this.lblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lblSifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSifremiUnuttum.Click += new System.EventHandler(this.lblSifremiUnuttum_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.btnDevamEt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamEt.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnDevamEt.Location = new System.Drawing.Point(40, 152);
            this.btnDevamEt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(192, 36);
            this.btnDevamEt.TabIndex = 30;
            this.btnDevamEt.Tag = "Devam Edin";
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = false;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnHesabimiSil
            // 
            this.btnHesabimiSil.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.btnHesabimiSil.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHesabimiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesabimiSil.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnHesabimiSil.Location = new System.Drawing.Point(40, 258);
            this.btnHesabimiSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesabimiSil.Name = "btnHesabimiSil";
            this.btnHesabimiSil.Size = new System.Drawing.Size(192, 36);
            this.btnHesabimiSil.TabIndex = 31;
            this.btnHesabimiSil.Tag = "";
            this.btnHesabimiSil.Text = "Hesabımı Sil";
            this.btnHesabimiSil.UseVisualStyleBackColor = false;
            this.btnHesabimiSil.Click += new System.EventHandler(this.btnHesabimiSil_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "GİRİŞ YAP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UyeKayit_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(254, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesabimiSil);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.chkHesabimiSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifreGir);
            this.Controls.Add(this.txtEpostaGir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UyeKayit_4";
            this.Text = "GİRİŞ YAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEpostaGir;
        private System.Windows.Forms.TextBox txtSifreGir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkHesabimiSil;
        private System.Windows.Forms.Label lblSifremiUnuttum;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnHesabimiSil;
        private System.Windows.Forms.Label label1;
    }
}