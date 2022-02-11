
namespace KaloriDeneme_1111
{
    partial class UyeBilgiGiris_2
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
            this.btnBilgiGirisiYap = new System.Windows.Forms.Button();
            this.btnBilgiGirisiYapma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGirisiYap
            // 
            this.btnBilgiGirisiYap.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.btnBilgiGirisiYap.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBilgiGirisiYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGirisiYap.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnBilgiGirisiYap.Location = new System.Drawing.Point(34, 99);
            this.btnBilgiGirisiYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnBilgiGirisiYap.Name = "btnBilgiGirisiYap";
            this.btnBilgiGirisiYap.Size = new System.Drawing.Size(192, 95);
            this.btnBilgiGirisiYap.TabIndex = 28;
            this.btnBilgiGirisiYap.Tag = "";
            this.btnBilgiGirisiYap.Text = "Bilgi Girişi Yapacağım";
            this.btnBilgiGirisiYap.UseVisualStyleBackColor = false;
            this.btnBilgiGirisiYap.Click += new System.EventHandler(this.btnBilgiGirisiYap_Click);
            // 
            // btnBilgiGirisiYapma
            // 
            this.btnBilgiGirisiYapma.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.btnBilgiGirisiYapma.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBilgiGirisiYapma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGirisiYapma.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnBilgiGirisiYapma.Location = new System.Drawing.Point(34, 198);
            this.btnBilgiGirisiYapma.Margin = new System.Windows.Forms.Padding(2);
            this.btnBilgiGirisiYapma.Name = "btnBilgiGirisiYapma";
            this.btnBilgiGirisiYapma.Size = new System.Drawing.Size(192, 65);
            this.btnBilgiGirisiYapma.TabIndex = 29;
            this.btnBilgiGirisiYapma.Tag = "";
            this.btnBilgiGirisiYapma.Text = "Bilgi Girişi Yapmayacağım";
            this.btnBilgiGirisiYapma.UseVisualStyleBackColor = false;
            this.btnBilgiGirisiYapma.Click += new System.EventHandler(this.btnBilgiGirisiYapma_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 30;
            this.label2.Text = "Aşağıdakilerden birini seçerek devam edin.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UyeBilgiGiris_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(254, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBilgiGirisiYapma);
            this.Controls.Add(this.btnBilgiGirisiYap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UyeBilgiGiris_2";
            this.Text = "UyeBilgiGiris_2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBilgiGirisiYap;
        private System.Windows.Forms.Button btnBilgiGirisiYapma;
        private System.Windows.Forms.Label label2;
    }
}