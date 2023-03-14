
namespace SinemaBufeSatis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtbilet = new System.Windows.Forms.TextBox();
            txtcay = new System.Windows.Forms.TextBox();
            txtsu = new System.Windows.Forms.TextBox();
            txtmisir = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            LblKasa = new System.Windows.Forms.Label();
            txtkasa = new System.Windows.Forms.Label();
            LblToplam = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(46, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(329, 39);
            label1.TabIndex = 0;
            label1.Text = "Sinema Büfe Satış Paneli";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(47, 42);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(831, 135);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(490, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(276, 132);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            groupBox1.Controls.Add(txtbilet);
            groupBox1.Controls.Add(txtcay);
            groupBox1.Controls.Add(txtsu);
            groupBox1.Controls.Add(txtmisir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(47, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(273, 404);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            // 
            // txtbilet
            // 
            txtbilet.Location = new System.Drawing.Point(81, 234);
            txtbilet.Name = "txtbilet";
            txtbilet.Size = new System.Drawing.Size(140, 31);
            txtbilet.TabIndex = 8;
            // 
            // txtcay
            // 
            txtcay.Location = new System.Drawing.Point(81, 182);
            txtcay.Name = "txtcay";
            txtcay.Size = new System.Drawing.Size(140, 31);
            txtcay.TabIndex = 7;
            // 
            // txtsu
            // 
            txtsu.Location = new System.Drawing.Point(81, 125);
            txtsu.Name = "txtsu";
            txtsu.Size = new System.Drawing.Size(140, 31);
            txtsu.TabIndex = 6;
            // 
            // txtmisir
            // 
            txtmisir.Location = new System.Drawing.Point(81, 71);
            txtmisir.Name = "txtmisir";
            txtmisir.Size = new System.Drawing.Size(140, 31);
            txtmisir.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 242);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 23);
            label5.TabIndex = 4;
            label5.Text = "Bilet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 23);
            label4.TabIndex = 3;
            label4.Text = "Çay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 23);
            label3.TabIndex = 2;
            label3.Text = "Su:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 1;
            label2.Text = "Mısır:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.LightCoral;
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new System.Drawing.Point(326, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(273, 404);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat Tablosu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(114, 234);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(30, 23);
            label13.TabIndex = 9;
            label13.Text = "8₺";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(114, 182);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(30, 23);
            label12.TabIndex = 8;
            label12.Text = "2₺";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(114, 128);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(30, 23);
            label11.TabIndex = 7;
            label11.Text = "1₺";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(114, 74);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(30, 23);
            label10.TabIndex = 6;
            label10.Text = "4₺";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(43, 234);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(53, 23);
            label9.TabIndex = 5;
            label9.Text = "Bilet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(53, 182);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 23);
            label8.TabIndex = 4;
            label8.Text = "Çay:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(62, 128);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 23);
            label7.TabIndex = 3;
            label7.Text = "Su:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(39, 74);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 23);
            label6.TabIndex = 2;
            label6.Text = "Mısır:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Azure;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(LblKasa);
            groupBox3.Controls.Add(txtkasa);
            groupBox3.Controls.Add(LblToplam);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new System.Drawing.Point(605, 183);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(273, 404);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            button2.Location = new System.Drawing.Point(86, 224);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(106, 33);
            button2.TabIndex = 10;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            button1.Location = new System.Drawing.Point(86, 151);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(106, 33);
            button1.TabIndex = 9;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LblKasa
            // 
            LblKasa.AutoSize = true;
            LblKasa.Location = new System.Drawing.Point(116, 299);
            LblKasa.Name = "LblKasa";
            LblKasa.Size = new System.Drawing.Size(30, 23);
            LblKasa.TabIndex = 8;
            LblKasa.Text = "0₺";
            // 
            // txtkasa
            // 
            txtkasa.AutoSize = true;
            txtkasa.Location = new System.Drawing.Point(42, 299);
            txtkasa.Name = "txtkasa";
            txtkasa.Size = new System.Drawing.Size(58, 23);
            txtkasa.TabIndex = 7;
            txtkasa.Text = "KASA:";
            // 
            // LblToplam
            // 
            LblToplam.AutoSize = true;
            LblToplam.Location = new System.Drawing.Point(131, 97);
            LblToplam.Name = "LblToplam";
            LblToplam.Size = new System.Drawing.Size(30, 23);
            LblToplam.TabIndex = 6;
            LblToplam.Text = "0₺";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(42, 97);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(71, 23);
            label14.TabIndex = 5;
            label14.Text = "Toplam:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(921, 629);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbilet;
        private System.Windows.Forms.TextBox txtcay;
        private System.Windows.Forms.TextBox txtsu;
        private System.Windows.Forms.TextBox txtmisir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Label txtkasa;
        private System.Windows.Forms.Label LblToplam;
        private System.Windows.Forms.Label label14;
    }
}

