namespace WindowsFormsApp3
{
    partial class Landbouw
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
            this.eenNaampje = new System.Windows.Forms.DataGridView();
            this.Vermogensmisdrijven = new System.Windows.Forms.RadioButton();
            this.AlleMisdrijven = new System.Windows.Forms.RadioButton();
            this.Vernielingen = new System.Windows.Forms.RadioButton();
            this.GeweldEnSeks = new System.Windows.Forms.RadioButton();
            this.WvSr = new System.Windows.Forms.RadioButton();
            this.Verkeer = new System.Windows.Forms.RadioButton();
            this.Drugs = new System.Windows.Forms.RadioButton();
            this.Wapen = new System.Windows.Forms.RadioButton();
            this.OverigeWetten = new System.Windows.Forms.RadioButton();
            this.LandGrid = new System.Windows.Forms.DataGridView();
            this.Recreatie = new System.Windows.Forms.RadioButton();
            this.Land = new System.Windows.Forms.RadioButton();
            this.groupBoxLandbouw = new System.Windows.Forms.GroupBox();
            this.groupBoxCrimi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandGrid)).BeginInit();
            this.groupBoxLandbouw.SuspendLayout();
            this.groupBoxCrimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // eenNaampje
            // 
            this.eenNaampje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eenNaampje.Location = new System.Drawing.Point(340, 12);
            this.eenNaampje.Name = "eenNaampje";
            this.eenNaampje.Size = new System.Drawing.Size(453, 421);
            this.eenNaampje.TabIndex = 5;
            this.eenNaampje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eenNaampje_CellContentClick);
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
            // LandGrid
            // 
            this.LandGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LandGrid.Location = new System.Drawing.Point(865, 12);
            this.LandGrid.Name = "LandGrid";
            this.LandGrid.Size = new System.Drawing.Size(417, 421);
            this.LandGrid.TabIndex = 15;
            this.LandGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LandGrid_CellContentClick);
            // 
            // Recreatie
            // 
            this.Recreatie.AutoSize = true;
            this.Recreatie.Location = new System.Drawing.Point(29, 23);
            this.Recreatie.Name = "Recreatie";
            this.Recreatie.Size = new System.Drawing.Size(71, 17);
            this.Recreatie.TabIndex = 17;
            this.Recreatie.TabStop = true;
            this.Recreatie.Text = "Recreatie";
            this.Recreatie.UseVisualStyleBackColor = true;
            this.Recreatie.CheckedChanged += new System.EventHandler(this.Recreatie_CheckedChanged);
            // 
            // Land
            // 
            this.Land.AutoSize = true;
            this.Land.Location = new System.Drawing.Point(29, 69);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(75, 17);
            this.Land.TabIndex = 18;
            this.Land.TabStop = true;
            this.Land.Text = "Landbouw";
            this.Land.UseVisualStyleBackColor = true;
            this.Land.CheckedChanged += new System.EventHandler(this.Land_CheckedChanged);
            // 
            // groupBoxLandbouw
            // 
            this.groupBoxLandbouw.Controls.Add(this.Land);
            this.groupBoxLandbouw.Controls.Add(this.Recreatie);
            this.groupBoxLandbouw.Location = new System.Drawing.Point(1356, 75);
            this.groupBoxLandbouw.Name = "groupBoxLandbouw";
            this.groupBoxLandbouw.Size = new System.Drawing.Size(200, 100);
            this.groupBoxLandbouw.TabIndex = 19;
            this.groupBoxLandbouw.TabStop = false;
            this.groupBoxLandbouw.Text = "Grondbouw Soorten";
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
            this.groupBoxCrimi.Location = new System.Drawing.Point(12, 28);
            this.groupBoxCrimi.Name = "groupBoxCrimi";
            this.groupBoxCrimi.Size = new System.Drawing.Size(311, 298);
            this.groupBoxCrimi.TabIndex = 20;
            this.groupBoxCrimi.TabStop = false;
            this.groupBoxCrimi.Text = "Misdrijf Soorten";
            // 
            // Landbouw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBoxCrimi);
            this.Controls.Add(this.groupBoxLandbouw);
            this.Controls.Add(this.LandGrid);
            this.Controls.Add(this.eenNaampje);
            this.Name = "Landbouw";
            this.Text = "Landbouw";
            this.Load += new System.EventHandler(this.Landbouw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandGrid)).EndInit();
            this.groupBoxLandbouw.ResumeLayout(false);
            this.groupBoxLandbouw.PerformLayout();
            this.groupBoxCrimi.ResumeLayout(false);
            this.groupBoxCrimi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eenNaampje;
        private System.Windows.Forms.RadioButton Vermogensmisdrijven;
        private System.Windows.Forms.RadioButton AlleMisdrijven;
        private System.Windows.Forms.RadioButton Vernielingen;
        private System.Windows.Forms.RadioButton GeweldEnSeks;
        private System.Windows.Forms.RadioButton WvSr;
        private System.Windows.Forms.RadioButton Verkeer;
        private System.Windows.Forms.RadioButton Drugs;
        private System.Windows.Forms.RadioButton Wapen;
        private System.Windows.Forms.RadioButton OverigeWetten;
        private System.Windows.Forms.DataGridView LandGrid;
        private System.Windows.Forms.RadioButton Recreatie;
        private System.Windows.Forms.RadioButton Land;
        private System.Windows.Forms.GroupBox groupBoxLandbouw;
        private System.Windows.Forms.GroupBox groupBoxCrimi;
    }
}