namespace WindowsFormsApp3
{
    partial class Ethniciteit
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
            this.groupBoxCrimi = new System.Windows.Forms.GroupBox();
            this.OverigeWetten = new System.Windows.Forms.RadioButton();
            this.Vermogensmisdrijven = new System.Windows.Forms.RadioButton();
            this.AlleMisdrijven = new System.Windows.Forms.RadioButton();
            this.Vernielingen = new System.Windows.Forms.RadioButton();
            this.Wapen = new System.Windows.Forms.RadioButton();
            this.GeweldEnSeks = new System.Windows.Forms.RadioButton();
            this.Drugs = new System.Windows.Forms.RadioButton();
            this.WvSr = new System.Windows.Forms.RadioButton();
            this.Verkeer = new System.Windows.Forms.RadioButton();
            this.eenNaampje = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autochtonen = new System.Windows.Forms.RadioButton();
            this.totAllochtonen = new System.Windows.Forms.RadioButton();
            this.westAllochtonen = new System.Windows.Forms.RadioButton();
            this.nonWestAllochtonen = new System.Windows.Forms.RadioButton();
            this.EthniciteitGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxCrimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EthniciteitGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCrimi
            // 
            this.groupBoxCrimi.Controls.Add(this.OverigeWetten);
            this.groupBoxCrimi.Controls.Add(this.Vermogensmisdrijven);
            this.groupBoxCrimi.Controls.Add(this.AlleMisdrijven);
            this.groupBoxCrimi.Controls.Add(this.Vernielingen);
            this.groupBoxCrimi.Controls.Add(this.Wapen);
            this.groupBoxCrimi.Controls.Add(this.GeweldEnSeks);
            this.groupBoxCrimi.Controls.Add(this.Drugs);
            this.groupBoxCrimi.Controls.Add(this.WvSr);
            this.groupBoxCrimi.Controls.Add(this.Verkeer);
            this.groupBoxCrimi.Location = new System.Drawing.Point(34, 59);
            this.groupBoxCrimi.Name = "groupBoxCrimi";
            this.groupBoxCrimi.Size = new System.Drawing.Size(311, 298);
            this.groupBoxCrimi.TabIndex = 22;
            this.groupBoxCrimi.TabStop = false;
            this.groupBoxCrimi.Text = "Misdrijf Soorten";
            // 
            // OverigeWetten
            // 
            this.OverigeWetten.AutoSize = true;
            this.OverigeWetten.Location = new System.Drawing.Point(34, 213);
            this.OverigeWetten.Name = "OverigeWetten";
            this.OverigeWetten.Size = new System.Drawing.Size(154, 17);
            this.OverigeWetten.TabIndex = 14;
            this.OverigeWetten.TabStop = true;
            this.OverigeWetten.Text = "9 Misdrijven overige wetten";
            this.OverigeWetten.UseVisualStyleBackColor = true;
            this.OverigeWetten.CheckedChanged += new System.EventHandler(this.OverigeWetten_CheckedChanged);
            // 
            // Vermogensmisdrijven
            // 
            this.Vermogensmisdrijven.AutoSize = true;
            this.Vermogensmisdrijven.Location = new System.Drawing.Point(34, 52);
            this.Vermogensmisdrijven.Name = "Vermogensmisdrijven";
            this.Vermogensmisdrijven.Size = new System.Drawing.Size(133, 17);
            this.Vermogensmisdrijven.TabIndex = 6;
            this.Vermogensmisdrijven.TabStop = true;
            this.Vermogensmisdrijven.Text = "1 Vermogensmisdrijven";
            this.Vermogensmisdrijven.UseVisualStyleBackColor = true;
            this.Vermogensmisdrijven.CheckedChanged += new System.EventHandler(this.Vermogensmisdrijven_CheckedChanged);
            // 
            // AlleMisdrijven
            // 
            this.AlleMisdrijven.AutoSize = true;
            this.AlleMisdrijven.Location = new System.Drawing.Point(34, 29);
            this.AlleMisdrijven.Name = "AlleMisdrijven";
            this.AlleMisdrijven.Size = new System.Drawing.Size(101, 17);
            this.AlleMisdrijven.TabIndex = 7;
            this.AlleMisdrijven.TabStop = true;
            this.AlleMisdrijven.Text = "0 Alle Misdrijven";
            this.AlleMisdrijven.UseVisualStyleBackColor = true;
            this.AlleMisdrijven.CheckedChanged += new System.EventHandler(this.AlleMisdrijven_CheckedChanged);
            // 
            // Vernielingen
            // 
            this.Vernielingen.AutoSize = true;
            this.Vernielingen.Location = new System.Drawing.Point(34, 75);
            this.Vernielingen.Name = "Vernielingen";
            this.Vernielingen.Size = new System.Drawing.Size(213, 17);
            this.Vernielingen.TabIndex = 8;
            this.Vernielingen.TabStop = true;
            this.Vernielingen.Text = "2 Vernielingen, misdr.openb.orde/gezag";
            this.Vernielingen.UseVisualStyleBackColor = true;
            // 
            // Wapen
            // 
            this.Wapen.AutoSize = true;
            this.Wapen.Location = new System.Drawing.Point(34, 190);
            this.Wapen.Name = "Wapen";
            this.Wapen.Size = new System.Drawing.Size(140, 17);
            this.Wapen.TabIndex = 13;
            this.Wapen.TabStop = true;
            this.Wapen.Text = "7 (Vuur)wapenmisdrijven";
            this.Wapen.UseVisualStyleBackColor = true;
            this.Wapen.CheckedChanged += new System.EventHandler(this.Wapen_CheckedChanged);
            // 
            // GeweldEnSeks
            // 
            this.GeweldEnSeks.AutoSize = true;
            this.GeweldEnSeks.Location = new System.Drawing.Point(34, 98);
            this.GeweldEnSeks.Name = "GeweldEnSeks";
            this.GeweldEnSeks.Size = new System.Drawing.Size(187, 17);
            this.GeweldEnSeks.TabIndex = 9;
            this.GeweldEnSeks.TabStop = true;
            this.GeweldEnSeks.Text = "3 Gewelds- en seksuele misdrijven";
            this.GeweldEnSeks.UseVisualStyleBackColor = true;
            this.GeweldEnSeks.CheckedChanged += new System.EventHandler(this.GeweldEnSeks_CheckedChanged);
            // 
            // Drugs
            // 
            this.Drugs.AutoSize = true;
            this.Drugs.Location = new System.Drawing.Point(34, 167);
            this.Drugs.Name = "Drugs";
            this.Drugs.Size = new System.Drawing.Size(108, 17);
            this.Drugs.TabIndex = 12;
            this.Drugs.TabStop = true;
            this.Drugs.Text = "6 Drugsmisdrijven";
            this.Drugs.UseVisualStyleBackColor = true;
            this.Drugs.CheckedChanged += new System.EventHandler(this.Drugs_CheckedChanged);
            // 
            // WvSr
            // 
            this.WvSr.AutoSize = true;
            this.WvSr.Location = new System.Drawing.Point(34, 121);
            this.WvSr.Name = "WvSr";
            this.WvSr.Size = new System.Drawing.Size(149, 17);
            this.WvSr.TabIndex = 10;
            this.WvSr.TabStop = true;
            this.WvSr.Text = "4 Misdrijven WvSr (overig)";
            this.WvSr.UseVisualStyleBackColor = true;
            this.WvSr.CheckedChanged += new System.EventHandler(this.WvSr_CheckedChanged);
            // 
            // Verkeer
            // 
            this.Verkeer.AutoSize = true;
            this.Verkeer.Location = new System.Drawing.Point(34, 144);
            this.Verkeer.Name = "Verkeer";
            this.Verkeer.Size = new System.Drawing.Size(122, 17);
            this.Verkeer.TabIndex = 11;
            this.Verkeer.TabStop = true;
            this.Verkeer.Text = "5 Verkeersmisdrijven";
            this.Verkeer.UseVisualStyleBackColor = true;
            this.Verkeer.CheckedChanged += new System.EventHandler(this.Verkeer_CheckedChanged);
            // 
            // eenNaampje
            // 
            this.eenNaampje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eenNaampje.Location = new System.Drawing.Point(362, 43);
            this.eenNaampje.Name = "eenNaampje";
            this.eenNaampje.Size = new System.Drawing.Size(453, 421);
            this.eenNaampje.TabIndex = 21;
            this.eenNaampje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eenNaampje_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nonWestAllochtonen);
            this.groupBox1.Controls.Add(this.westAllochtonen);
            this.groupBox1.Controls.Add(this.totAllochtonen);
            this.groupBox1.Controls.Add(this.autochtonen);
            this.groupBox1.Location = new System.Drawing.Point(1483, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 344);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // autochtonen
            // 
            this.autochtonen.AutoSize = true;
            this.autochtonen.Location = new System.Drawing.Point(19, 31);
            this.autochtonen.Name = "autochtonen";
            this.autochtonen.Size = new System.Drawing.Size(86, 17);
            this.autochtonen.TabIndex = 0;
            this.autochtonen.TabStop = true;
            this.autochtonen.Text = "Autochtonen";
            this.autochtonen.UseVisualStyleBackColor = true;
            this.autochtonen.CheckedChanged += new System.EventHandler(this.autochtonen_CheckedChanged);
            // 
            // totAllochtonen
            // 
            this.totAllochtonen.AutoSize = true;
            this.totAllochtonen.Location = new System.Drawing.Point(19, 54);
            this.totAllochtonen.Name = "totAllochtonen";
            this.totAllochtonen.Size = new System.Drawing.Size(145, 17);
            this.totAllochtonen.TabIndex = 1;
            this.totAllochtonen.TabStop = true;
            this.totAllochtonen.Text = "Totaal aantal allochtonen";
            this.totAllochtonen.UseVisualStyleBackColor = true;
            this.totAllochtonen.CheckedChanged += new System.EventHandler(this.totAllochtonen_CheckedChanged);
            // 
            // westAllochtonen
            // 
            this.westAllochtonen.AutoSize = true;
            this.westAllochtonen.Location = new System.Drawing.Point(19, 77);
            this.westAllochtonen.Name = "westAllochtonen";
            this.westAllochtonen.Size = new System.Drawing.Size(128, 17);
            this.westAllochtonen.TabIndex = 2;
            this.westAllochtonen.TabStop = true;
            this.westAllochtonen.Text = "Westerse allochtonen";
            this.westAllochtonen.UseVisualStyleBackColor = true;
            this.westAllochtonen.CheckedChanged += new System.EventHandler(this.westAllochtonen_CheckedChanged);
            // 
            // nonWestAllochtonen
            // 
            this.nonWestAllochtonen.AutoSize = true;
            this.nonWestAllochtonen.Location = new System.Drawing.Point(19, 100);
            this.nonWestAllochtonen.Name = "nonWestAllochtonen";
            this.nonWestAllochtonen.Size = new System.Drawing.Size(147, 17);
            this.nonWestAllochtonen.TabIndex = 3;
            this.nonWestAllochtonen.TabStop = true;
            this.nonWestAllochtonen.Text = "Niet westerse allochtonen";
            this.nonWestAllochtonen.UseVisualStyleBackColor = true;
            this.nonWestAllochtonen.CheckedChanged += new System.EventHandler(this.nonWestAllochtonen_CheckedChanged);
            // 
            // EthniciteitGrid
            // 
            this.EthniciteitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EthniciteitGrid.Location = new System.Drawing.Point(886, 43);
            this.EthniciteitGrid.Name = "EthniciteitGrid";
            this.EthniciteitGrid.Size = new System.Drawing.Size(473, 421);
            this.EthniciteitGrid.TabIndex = 24;
            // 
            // Ethniciteit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1964, 981);
            this.Controls.Add(this.EthniciteitGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCrimi);
            this.Controls.Add(this.eenNaampje);
            this.Name = "Ethniciteit";
            this.Text = "Ethniciteit";
            this.groupBoxCrimi.ResumeLayout(false);
            this.groupBoxCrimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EthniciteitGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCrimi;
        private System.Windows.Forms.RadioButton OverigeWetten;
        private System.Windows.Forms.RadioButton Vermogensmisdrijven;
        private System.Windows.Forms.RadioButton AlleMisdrijven;
        private System.Windows.Forms.RadioButton Vernielingen;
        private System.Windows.Forms.RadioButton Wapen;
        private System.Windows.Forms.RadioButton GeweldEnSeks;
        private System.Windows.Forms.RadioButton Drugs;
        private System.Windows.Forms.RadioButton WvSr;
        private System.Windows.Forms.RadioButton Verkeer;
        private System.Windows.Forms.DataGridView eenNaampje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nonWestAllochtonen;
        private System.Windows.Forms.RadioButton westAllochtonen;
        private System.Windows.Forms.RadioButton totAllochtonen;
        private System.Windows.Forms.RadioButton autochtonen;
        private System.Windows.Forms.DataGridView EthniciteitGrid;
    }
}