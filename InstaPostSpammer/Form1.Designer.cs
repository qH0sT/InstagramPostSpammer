namespace InstaPostSpammer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDogrulama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(105, 6);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(185, 23);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(105, 35);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(185, 23);
            this.txtParola.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // btnBaslat
            // 
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.Green;
            this.btnBaslat.Location = new System.Drawing.Point(296, 6);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(72, 52);
            this.btnBaslat.TabIndex = 4;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDogrulama
            // 
            this.txtDogrulama.Location = new System.Drawing.Point(130, 12);
            this.txtDogrulama.Name = "txtDogrulama";
            this.txtDogrulama.PasswordChar = '*';
            this.txtDogrulama.Size = new System.Drawing.Size(185, 23);
            this.txtDogrulama.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Doğrulama Kodu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 96);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "#sagopakajmer_resmi\r\n#KuvvetMira\r\n#SagoKeyShit\r\n#SagopaKajmer\r\n@etiketlenecek_kul" +
    "lanici_nicki";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDogrulama);
            this.panel1.Location = new System.Drawing.Point(25, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 48);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Beni hatırla";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(105, 63);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(122, 21);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "Parolayı göster";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 17);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hakkında";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sagopa Kajmer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 298);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.numericUpDown4);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.numericUpDown3);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtKullaniciAdi);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtParola);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.btnBaslat);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Panel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Tekrar sayısı:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(377, 26);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(78, 23);
            this.numericUpDown4.TabIndex = 36;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "her";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "sn bekle";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(320, 89);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(63, 23);
            this.numericUpDown3.TabIndex = 34;
            this.numericUpDown3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "yorumda";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(173, 87);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(71, 23);
            this.numericUpDown2.TabIndex = 32;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Gönderi URL:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(437, 23);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "https://www.instagram.com/p/B4qMYvkF7H2/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Yorum Arası Saniye ayarı:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(402, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 23);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loglar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 262);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(471, 298);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Auto Commenter V3.52.1 By Sagopa K";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDogrulama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

