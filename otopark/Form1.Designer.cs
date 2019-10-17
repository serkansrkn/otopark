namespace otopark
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tikKontak = new System.Windows.Forms.CheckBox();
            this.tikAbone = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lstbxAractip = new System.Windows.Forms.ListBox();
            this.lblAractip = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctxtMSCıkıs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cıkısYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctxtMSCıkıs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tikKontak);
            this.groupBox1.Controls.Add(this.tikAbone);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.lstbxAractip);
            this.groupBox1.Controls.Add(this.lblAractip);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // tikKontak
            // 
            this.tikKontak.AutoSize = true;
            this.tikKontak.Location = new System.Drawing.Point(67, 136);
            this.tikKontak.Name = "tikKontak";
            this.tikKontak.Size = new System.Drawing.Size(78, 17);
            this.tikKontak.TabIndex = 4;
            this.tikKontak.Text = "Kontak var";
            this.tikKontak.UseVisualStyleBackColor = true;
            // 
            // tikAbone
            // 
            this.tikAbone.AutoSize = true;
            this.tikAbone.Location = new System.Drawing.Point(171, 136);
            this.tikAbone.Name = "tikAbone";
            this.tikAbone.Size = new System.Drawing.Size(57, 17);
            this.tikAbone.TabIndex = 3;
            this.tikAbone.Text = "Abone";
            this.tikAbone.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(156, 164);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // lstbxAractip
            // 
            this.lstbxAractip.FormattingEnabled = true;
            this.lstbxAractip.Location = new System.Drawing.Point(67, 48);
            this.lstbxAractip.Name = "lstbxAractip";
            this.lstbxAractip.Size = new System.Drawing.Size(164, 82);
            this.lstbxAractip.TabIndex = 2;
            // 
            // lblAractip
            // 
            this.lblAractip.AutoSize = true;
            this.lblAractip.Location = new System.Drawing.Point(6, 48);
            this.lblAractip.Name = "lblAractip";
            this.lblAractip.Size = new System.Drawing.Size(49, 13);
            this.lblAractip.TabIndex = 0;
            this.lblAractip.Text = "Araç Tipi";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(67, 15);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(164, 20);
            this.txtPlaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAraclar);
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otoparktaki Araçlar";
            // 
            // lstAraclar
            // 
            this.lstAraclar.ContextMenuStrip = this.ctxtMSCıkıs;
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(7, 22);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(497, 355);
            this.lstAraclar.TabIndex = 0;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.LstAraclar_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblUcret);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblSaat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblPlaka);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Günlük Satış Raporu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(94, 117);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(55, 25);
            this.lblUcret.TabIndex = 0;
            this.lblUcret.Text = "0 TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ücret";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(94, 71);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(74, 25);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "0 Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Süre";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(94, 28);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(106, 25);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "00 xx 000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plaka";
            // 
            // ctxtMSCıkıs
            // 
            this.ctxtMSCıkıs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cıkısYapToolStripMenuItem});
            this.ctxtMSCıkıs.Name = "ctxtMSCıkıs";
            this.ctxtMSCıkıs.Size = new System.Drawing.Size(122, 26);
            
            this.ctxtMSCıkıs.Click += new System.EventHandler(this.Cıkıs_Yap);
            // 
            // cıkısYapToolStripMenuItem
            // 
            this.cıkısYapToolStripMenuItem.Name = "cıkısYapToolStripMenuItem";
            this.cıkısYapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cıkısYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Otopark Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ctxtMSCıkıs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox tikAbone;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ListBox lstbxAractip;
        private System.Windows.Forms.Label lblAractip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox tikKontak;
        private System.Windows.Forms.ContextMenuStrip ctxtMSCıkıs;
        private System.Windows.Forms.ToolStripMenuItem cıkısYapToolStripMenuItem;
    }
}

