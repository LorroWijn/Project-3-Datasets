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
            this.groupBoxCrimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).BeginInit();
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
            // Leeftijden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBoxCrimi);
            this.Controls.Add(this.eenNaampje);
            this.Name = "Leeftijden";
            this.Text = "Leeftijden";
            this.groupBoxCrimi.ResumeLayout(false);
            this.groupBoxCrimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).EndInit();
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
    }
}