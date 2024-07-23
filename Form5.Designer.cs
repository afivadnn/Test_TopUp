namespace Topup
{
    partial class Form5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dana = new System.Windows.Forms.Button();
            this.Alfa = new System.Windows.Forms.Button();
            this.Bri = new System.Windows.Forms.Button();
            this.Gopay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Topup.Properties.Resources.Desain_tanpa_judul__4_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Topup.Properties.Resources.Desain_tanpa_judul__3_;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pilih Metode Pembayaran";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::Topup.Properties.Resources.dm__4_;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(9, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 33);
            this.back.TabIndex = 13;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Topup.Properties.Resources.Desain_tanpa_judul__3_;
            this.groupBox1.Controls.Add(this.Dana);
            this.groupBox1.Controls.Add(this.Alfa);
            this.groupBox1.Controls.Add(this.Bri);
            this.groupBox1.Controls.Add(this.Gopay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(31, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 410);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Dana
            // 
            this.Dana.BackgroundImage = global::Topup.Properties.Resources.dm__9_;
            this.Dana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dana.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Dana.Location = new System.Drawing.Point(20, 118);
            this.Dana.Name = "Dana";
            this.Dana.Size = new System.Drawing.Size(182, 98);
            this.Dana.TabIndex = 7;
            this.Dana.UseVisualStyleBackColor = true;
            this.Dana.Click += new System.EventHandler(this.Dana_Click);
            // 
            // Alfa
            // 
            this.Alfa.BackgroundImage = global::Topup.Properties.Resources.dm__12_;
            this.Alfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alfa.ForeColor = System.Drawing.Color.Black;
            this.Alfa.Location = new System.Drawing.Point(262, 256);
            this.Alfa.Name = "Alfa";
            this.Alfa.Size = new System.Drawing.Size(182, 98);
            this.Alfa.TabIndex = 7;
            this.Alfa.UseVisualStyleBackColor = true;
            this.Alfa.Click += new System.EventHandler(this.button4_Click);
            // 
            // Bri
            // 
            this.Bri.BackgroundImage = global::Topup.Properties.Resources.dm__11_;
            this.Bri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bri.ForeColor = System.Drawing.Color.Black;
            this.Bri.Location = new System.Drawing.Point(20, 256);
            this.Bri.Name = "Bri";
            this.Bri.Size = new System.Drawing.Size(182, 98);
            this.Bri.TabIndex = 7;
            this.Bri.UseVisualStyleBackColor = true;
            this.Bri.Click += new System.EventHandler(this.Bri_Click);
            // 
            // Gopay
            // 
            this.Gopay.BackgroundImage = global::Topup.Properties.Resources.dm__8_;
            this.Gopay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gopay.ForeColor = System.Drawing.Color.Black;
            this.Gopay.Location = new System.Drawing.Point(262, 118);
            this.Gopay.Name = "Gopay";
            this.Gopay.Size = new System.Drawing.Size(182, 98);
            this.Gopay.TabIndex = 7;
            this.Gopay.UseVisualStyleBackColor = true;
            this.Gopay.Click += new System.EventHandler(this.Gopay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Topup.Properties.Resources.Desain_tanpa_judul__4_;
            this.label2.Location = new System.Drawing.Point(13, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "3";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Topup.Properties.Resources.Desain_tanpa_judul__7_;
            this.ClientSize = new System.Drawing.Size(534, 505);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metode Pembayaran";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dana;
        private System.Windows.Forms.Button Alfa;
        private System.Windows.Forms.Button Bri;
        private System.Windows.Forms.Button Gopay;
    }
}