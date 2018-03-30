namespace WindowsFormsApp3
{
    partial class HoofdschermForm
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
            this.database1DataSet = new WindowsFormsApp3.Database1DataSet();
            this.CrimiVSGrond = new System.Windows.Forms.Button();
            this.CrimiVSAfkomst = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eenNaampje = new System.Windows.Forms.DataGridView();
            this.misdrijfNamen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misdrijfNamen)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CrimiVSGrond
            // 
            this.CrimiVSGrond.BackColor = System.Drawing.SystemColors.Control;
            this.CrimiVSGrond.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.aceon6jBi;
            this.CrimiVSGrond.Location = new System.Drawing.Point(1005, 487);
            this.CrimiVSGrond.Name = "CrimiVSGrond";
            this.CrimiVSGrond.Size = new System.Drawing.Size(512, 512);
            this.CrimiVSGrond.TabIndex = 0;
            this.CrimiVSGrond.Text = "Criminaliteit versus Landbouw/Grondbouw";
            this.CrimiVSGrond.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CrimiVSGrond.UseVisualStyleBackColor = false;
            this.CrimiVSGrond.Click += new System.EventHandler(this.CrimiVSGrond_Click);
            // 
            // CrimiVSAfkomst
            // 
            this.CrimiVSAfkomst.Location = new System.Drawing.Point(171, 487);
            this.CrimiVSAfkomst.Name = "CrimiVSAfkomst";
            this.CrimiVSAfkomst.Size = new System.Drawing.Size(512, 512);
            this.CrimiVSAfkomst.TabIndex = 2;
            this.CrimiVSAfkomst.Text = "Criminaliteit versus Afkomst/Ethniciteit";
            this.CrimiVSAfkomst.UseVisualStyleBackColor = true;
            this.CrimiVSAfkomst.Click += new System.EventHandler(this.CrimiVSAfkomst_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(808, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 85);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Fantastic Four\'s project 3: \r\nDatabases";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // eenNaampje
            // 
            this.eenNaampje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eenNaampje.Location = new System.Drawing.Point(171, 46);
            this.eenNaampje.Name = "eenNaampje";
            this.eenNaampje.Size = new System.Drawing.Size(453, 421);
            this.eenNaampje.TabIndex = 4;
            // 
            // misdrijfNamen
            // 
            this.misdrijfNamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.misdrijfNamen.Location = new System.Drawing.Point(647, 46);
            this.misdrijfNamen.Name = "misdrijfNamen";
            this.misdrijfNamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.misdrijfNamen.Size = new System.Drawing.Size(282, 384);
            this.misdrijfNamen.TabIndex = 5;
            this.misdrijfNamen.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.misdrijfNamen_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._2__2522274_Flag_20Of_20Nederland;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.misdrijfNamen);
            this.Controls.Add(this.eenNaampje);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CrimiVSAfkomst);
            this.Controls.Add(this.CrimiVSGrond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eenNaampje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misdrijfNamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button CrimiVSGrond;
        private System.Windows.Forms.Button CrimiVSAfkomst;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView eenNaampje;
        private System.Windows.Forms.DataGridView misdrijfNamen;
    }
}

