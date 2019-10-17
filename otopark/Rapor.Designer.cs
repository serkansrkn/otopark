namespace otopark
{
    partial class Rapor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTplmUcret = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTplmArc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 438);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Araç Tipi";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Abone";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Süre";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ücret";
            this.columnHeader4.Width = 76;
            // 
            // lblTplmUcret
            // 
            this.lblTplmUcret.AutoSize = true;
            this.lblTplmUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTplmUcret.Location = new System.Drawing.Point(548, 191);
            this.lblTplmUcret.Name = "lblTplmUcret";
            this.lblTplmUcret.Size = new System.Drawing.Size(68, 31);
            this.lblTplmUcret.TabIndex = 1;
            this.lblTplmUcret.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(548, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Toplam Ücret";
            // 
            // lblTplmArc
            // 
            this.lblTplmArc.AutoSize = true;
            this.lblTplmArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTplmArc.Location = new System.Drawing.Point(548, 60);
            this.lblTplmArc.Name = "lblTplmArc";
            this.lblTplmArc.Size = new System.Drawing.Size(29, 31);
            this.lblTplmArc.TabIndex = 3;
            this.lblTplmArc.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(548, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Toplam Araç ";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giriş";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Çıkış";
            this.columnHeader7.Width = 82;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.lblTplmUcret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTplmArc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label lblTplmUcret;
        public System.Windows.Forms.Label lblTplmArc;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}