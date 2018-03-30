namespace WindowsFormsApp3
{
    partial class Leeftijden
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
            this.groupBoxLeeftijden = new System.Windows.Forms.GroupBox();
            this.xJongerDan5 = new System.Windows.Forms.RadioButton();
            this.x5tot10 = new System.Windows.Forms.RadioButton();
            this.x10tot15 = new System.Windows.Forms.RadioButton();
            this.x15tot20 = new System.Windows.Forms.RadioButton();
            this.x20tot25 = new System.Windows.Forms.RadioButton();
            this.x45tot65 = new System.Windows.Forms.RadioButton();
            this.x65tot80 = new System.Windows.Forms.RadioButton();
            this.xOuderDan80 = new System.Windows.Forms.RadioButton();
            this.x25tot45 = new System.Windows.Forms.RadioButton();
            this.LeefijdGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxCrimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).BeginInit();
            this.groupBoxLeeftijden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeefijdGrid)).BeginInit();
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
            this.groupBoxCrimi.Location = new System.Drawing.Point(37, 63);
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
            this.Vernielingen.CheckedChanged += new System.EventHandler(this.Vernielingen_CheckedChanged);
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
            this.eenNaampje.Location = new System.Drawing.Point(365, 47);
            this.eenNaampje.Name = "eenNaampje";
            this.eenNaampje.Size = new System.Drawing.Size(453, 421);
            this.eenNaampje.TabIndex = 21;
            this.eenNaampje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eenNaampje_CellContentClick);
            // 
            // groupBoxLeeftijden
            // 
            this.groupBoxLeeftijden.Controls.Add(this.x25tot45);
            this.groupBoxLeeftijden.Controls.Add(this.xOuderDan80);
            this.groupBoxLeeftijden.Controls.Add(this.x65tot80);
            this.groupBoxLeeftijden.Controls.Add(this.x45tot65);
            this.groupBoxLeeftijden.Controls.Add(this.x20tot25);
            this.groupBoxLeeftijden.Controls.Add(this.x15tot20);
            this.groupBoxLeeftijden.Controls.Add(this.x10tot15);
            this.groupBoxLeeftijden.Controls.Add(this.x5tot10);
            this.groupBoxLeeftijden.Controls.Add(this.xJongerDan5);
            this.groupBoxLeeftijden.Location = new System.Drawing.Point(1364, 63);
            this.groupBoxLeeftijden.Name = "groupBoxLeeftijden";
            this.groupBoxLeeftijden.Size = new System.Drawing.Size(200, 298);
            this.groupBoxLeeftijden.TabIndex = 23;
            this.groupBoxLeeftijden.TabStop = false;
            this.groupBoxLeeftijden.Text = "Leeftijden";
            // 
            // xJongerDan5
            // 
            this.xJongerDan5.AutoSize = true;
            this.xJongerDan5.Location = new System.Drawing.Point(6, 29);
            this.xJongerDan5.Name = "xJongerDan5";
            this.xJongerDan5.Size = new System.Drawing.Size(107, 17);
            this.xJongerDan5.TabIndex = 0;
            this.xJongerDan5.TabStop = true;
            this.xJongerDan5.Text = "Jonger dan 5 jaar";
            this.xJongerDan5.UseVisualStyleBackColor = true;
            this.xJongerDan5.CheckedChanged += new System.EventHandler(this.xJongerDan5_CheckedChanged);
            // 
            // x5tot10
            // 
            this.x5tot10.AutoSize = true;
            this.x5tot10.Location = new System.Drawing.Point(6, 52);
            this.x5tot10.Name = "x5tot10";
            this.x5tot10.Size = new System.Drawing.Size(102, 17);
            this.x5tot10.TabIndex = 1;
            this.x5tot10.TabStop = true;
            this.x5tot10.Text = "van 5 tot 10 jaar";
            this.x5tot10.UseVisualStyleBackColor = true;
            this.x5tot10.CheckedChanged += new System.EventHandler(this.x5tot10_CheckedChanged);
            // 
            // x10tot15
            // 
            this.x10tot15.AutoSize = true;
            this.x10tot15.Location = new System.Drawing.Point(6, 75);
            this.x10tot15.Name = "x10tot15";
            this.x10tot15.Size = new System.Drawing.Size(108, 17);
            this.x10tot15.TabIndex = 2;
            this.x10tot15.TabStop = true;
            this.x10tot15.Text = "van 10 tot 15 jaar";
            this.x10tot15.UseVisualStyleBackColor = true;
            this.x10tot15.CheckedChanged += new System.EventHandler(this.x10tot15_CheckedChanged);
            // 
            // x15tot20
            // 
            this.x15tot20.AutoSize = true;
            this.x15tot20.Location = new System.Drawing.Point(6, 98);
            this.x15tot20.Name = "x15tot20";
            this.x15tot20.Size = new System.Drawing.Size(108, 17);
            this.x15tot20.TabIndex = 3;
            this.x15tot20.TabStop = true;
            this.x15tot20.Text = "van 15 tot 20 jaar";
            this.x15tot20.UseVisualStyleBackColor = true;
            this.x15tot20.CheckedChanged += new System.EventHandler(this.x15tot20_CheckedChanged);
            // 
            // x20tot25
            // 
            this.x20tot25.AutoSize = true;
            this.x20tot25.Location = new System.Drawing.Point(6, 121);
            this.x20tot25.Name = "x20tot25";
            this.x20tot25.Size = new System.Drawing.Size(108, 17);
            this.x20tot25.TabIndex = 4;
            this.x20tot25.TabStop = true;
            this.x20tot25.Text = "van 20 tot 25 jaar";
            this.x20tot25.UseVisualStyleBackColor = true;
            this.x20tot25.CheckedChanged += new System.EventHandler(this.x20tot25_CheckedChanged);
            // 
            // x45tot65
            // 
            this.x45tot65.AutoSize = true;
            this.x45tot65.Location = new System.Drawing.Point(6, 167);
            this.x45tot65.Name = "x45tot65";
            this.x45tot65.Size = new System.Drawing.Size(108, 17);
            this.x45tot65.TabIndex = 5;
            this.x45tot65.TabStop = true;
            this.x45tot65.Text = "van 45 tot 65 jaar";
            this.x45tot65.UseVisualStyleBackColor = true;
            this.x45tot65.CheckedChanged += new System.EventHandler(this.x45tot65_CheckedChanged);
            // 
            // x65tot80
            // 
            this.x65tot80.AutoSize = true;
            this.x65tot80.Location = new System.Drawing.Point(5, 190);
            this.x65tot80.Name = "x65tot80";
            this.x65tot80.Size = new System.Drawing.Size(108, 17);
            this.x65tot80.TabIndex = 6;
            this.x65tot80.TabStop = true;
            this.x65tot80.Text = "van 65 tot 80 jaar";
            this.x65tot80.UseVisualStyleBackColor = true;
            this.x65tot80.CheckedChanged += new System.EventHandler(this.x65tot80_CheckedChanged);
            // 
            // xOuderDan80
            // 
            this.xOuderDan80.AutoSize = true;
            this.xOuderDan80.Location = new System.Drawing.Point(5, 213);
            this.xOuderDan80.Name = "xOuderDan80";
            this.xOuderDan80.Size = new System.Drawing.Size(108, 17);
            this.xOuderDan80.TabIndex = 7;
            this.xOuderDan80.TabStop = true;
            this.xOuderDan80.Text = "ouder dan 80 jaar";
            this.xOuderDan80.UseVisualStyleBackColor = true;
            this.xOuderDan80.CheckedChanged += new System.EventHandler(this.xOuderDan80_CheckedChanged);
            // 
            // x25tot45
            // 
            this.x25tot45.AutoSize = true;
            this.x25tot45.Location = new System.Drawing.Point(6, 144);
            this.x25tot45.Name = "x25tot45";
            this.x25tot45.Size = new System.Drawing.Size(108, 17);
            this.x25tot45.TabIndex = 8;
            this.x25tot45.TabStop = true;
            this.x25tot45.Text = "van 25 tot 45 jaar";
            this.x25tot45.UseVisualStyleBackColor = true;
            this.x25tot45.CheckedChanged += new System.EventHandler(this.x25tot45_CheckedChanged);
            // 
            // LeefijdGrid
            // 
            this.LeefijdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeefijdGrid.Location = new System.Drawing.Point(862, 47);
            this.LeefijdGrid.Name = "LeefijdGrid";
            this.LeefijdGrid.Size = new System.Drawing.Size(380, 421);
            this.LeefijdGrid.TabIndex = 24;
            this.LeefijdGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeefijdGrid_CellContentClick);
            // 
            // Leeftijden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LeefijdGrid);
            this.Controls.Add(this.groupBoxLeeftijden);
            this.Controls.Add(this.groupBoxCrimi);
            this.Controls.Add(this.eenNaampje);
            this.Name = "Leeftijden";
            this.Text = "Leeftijden";
            this.groupBoxCrimi.ResumeLayout(false);
            this.groupBoxCrimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).EndInit();
            this.groupBoxLeeftijden.ResumeLayout(false);
            this.groupBoxLeeftijden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeefijdGrid)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxLeeftijden;
        private System.Windows.Forms.RadioButton x65tot80;
        private System.Windows.Forms.RadioButton x45tot65;
        private System.Windows.Forms.RadioButton x20tot25;
        private System.Windows.Forms.RadioButton x15tot20;
        private System.Windows.Forms.RadioButton x10tot15;
        private System.Windows.Forms.RadioButton x5tot10;
        private System.Windows.Forms.RadioButton xJongerDan5;
        private System.Windows.Forms.RadioButton xOuderDan80;
        private System.Windows.Forms.RadioButton x25tot45;
        private System.Windows.Forms.DataGridView LeefijdGrid;
    }
}