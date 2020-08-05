namespace SirketOtomasyonu
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisButton = new FontAwesome.Sharp.IconButton();
            this.textBoxMailGiris = new System.Windows.Forms.TextBox();
            this.textBoxSifreGiris = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kayitYazi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // girisButton
            // 
            this.girisButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.girisButton.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.girisButton.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.girisButton.IconColor = System.Drawing.Color.Black;
            this.girisButton.IconSize = 32;
            this.girisButton.Location = new System.Drawing.Point(361, 375);
            this.girisButton.Name = "girisButton";
            this.girisButton.Rotation = 0D;
            this.girisButton.Size = new System.Drawing.Size(193, 43);
            this.girisButton.TabIndex = 1;
            this.girisButton.Text = "GİRİŞ YAP";
            this.girisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // textBoxMailGiris
            // 
            this.textBoxMailGiris.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMailGiris.Location = new System.Drawing.Point(331, 204);
            this.textBoxMailGiris.Multiline = true;
            this.textBoxMailGiris.Name = "textBoxMailGiris";
            this.textBoxMailGiris.Size = new System.Drawing.Size(259, 34);
            this.textBoxMailGiris.TabIndex = 2;
            // 
            // textBoxSifreGiris
            // 
            this.textBoxSifreGiris.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifreGiris.Location = new System.Drawing.Point(331, 299);
            this.textBoxSifreGiris.Multiline = true;
            this.textBoxSifreGiris.Name = "textBoxSifreGiris";
            this.textBoxSifreGiris.PasswordChar = '•';
            this.textBoxSifreGiris.Size = new System.Drawing.Size(259, 34);
            this.textBoxSifreGiris.TabIndex = 3;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mailLabel.Location = new System.Drawing.Point(357, 165);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(222, 22);
            this.mailLabel.TabIndex = 4;
            this.mailLabel.Text = "Mail Adresi / Mail Address";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.sifreLabel.Location = new System.Drawing.Point(387, 264);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(144, 22);
            this.sifreLabel.TabIndex = 5;
            this.sifreLabel.Text = "Şifre / Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(605, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "© 2020 - Ahmet Göçer";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(898, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(870, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 33);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(840, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 33);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kayitYazi
            // 
            this.kayitYazi.AutoSize = true;
            this.kayitYazi.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitYazi.ForeColor = System.Drawing.Color.Gainsboro;
            this.kayitYazi.Location = new System.Drawing.Point(327, 439);
            this.kayitYazi.Name = "kayitYazi";
            this.kayitYazi.Size = new System.Drawing.Size(261, 22);
            this.kayitYazi.TabIndex = 12;
            this.kayitYazi.Text = "Hesabınız yok mu? Kayıt Olun.";
            this.kayitYazi.Click += new System.EventHandler(this.kayitYazi_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(932, 499);
            this.Controls.Add(this.kayitYazi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.textBoxSifreGiris);
            this.Controls.Add(this.textBoxMailGiris);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GirisYap";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton girisButton;
        private System.Windows.Forms.TextBox textBoxMailGiris;
        private System.Windows.Forms.TextBox textBoxSifreGiris;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label kayitYazi;
    }
}

