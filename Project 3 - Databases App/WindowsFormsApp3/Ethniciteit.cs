using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Ethniciteit : Form
    {
        public Ethniciteit()
        {
            InitializeComponent();

            linksHeleKaart.Controls.Add(linksDrentheKaart);

            linksDrentheKaart.Location = new Point(0, 0);
            linksDrentheKaart.BackColor = Color.Transparent;
            linksDrentheKaart.Controls.Add(linksFlevolandKaart);

            linksFlevolandKaart.Location = new Point(0, 0);
            linksFlevolandKaart.BackColor = Color.Transparent;
            linksFlevolandKaart.Controls.Add(linksFrieslandKaart);

            linksFrieslandKaart.Location = new Point(0, 0);
            linksFrieslandKaart.BackColor = Color.Transparent;
            linksFrieslandKaart.Controls.Add(linksGelderlandKaart);

            linksGelderlandKaart.Location = new Point(0, 0);
            linksGelderlandKaart.BackColor = Color.Transparent;
            linksGelderlandKaart.Controls.Add(linksGroningenKaart);

            linksGroningenKaart.Location = new Point(0, 0);
            linksGroningenKaart.BackColor = Color.Transparent;
            linksGroningenKaart.Controls.Add(linksLimburgKaart);

            linksLimburgKaart.Location = new Point(0, 0);
            linksLimburgKaart.BackColor = Color.Transparent;
            linksLimburgKaart.Controls.Add(linksNoordbKaart);

            linksNoordbKaart.Location = new Point(0, 0);
            linksNoordbKaart.BackColor = Color.Transparent;
            linksNoordbKaart.Controls.Add(linksNoordhKaart);

            linksNoordhKaart.Location = new Point(0, 0);
            linksNoordhKaart.BackColor = Color.Transparent;
            linksNoordhKaart.Controls.Add(linksOverijsselKaart);

            linksOverijsselKaart.Location = new Point(0, 0);
            linksOverijsselKaart.BackColor = Color.Transparent;
            linksOverijsselKaart.Controls.Add(linksUtrechtKaart);

            linksUtrechtKaart.Location = new Point(0, 0);
            linksUtrechtKaart.BackColor = Color.Transparent;
            linksUtrechtKaart.Controls.Add(linksZeelandKaart);

            linksZeelandKaart.Location = new Point(0, 0);
            linksZeelandKaart.BackColor = Color.Transparent;
            linksZeelandKaart.Controls.Add(linksZuidhKaart);

            linksZuidhKaart.Location = new Point(0, 0);
            linksZuidhKaart.BackColor = Color.Transparent;
            linksZuidhKaart.Controls.Add(linksOutlineKaart);

            linksOutlineKaart.Location = new Point(0, 0);
            linksOutlineKaart.BackColor = Color.Transparent;

            //-----------------------------------------------------------------------------------------------------------------------
            rechtsHeleKaart.Controls.Add(rechtsDrentheKaart);

            rechtsDrentheKaart.Location = new Point(0, 0);
            rechtsDrentheKaart.BackColor = Color.Transparent;
            rechtsDrentheKaart.Controls.Add(rechtsFlevolandKaart);

            rechtsFlevolandKaart.Location = new Point(0, 0);
            rechtsFlevolandKaart.BackColor = Color.Transparent;
            rechtsFlevolandKaart.Controls.Add(rechtsFrieslandKaart);

            rechtsFrieslandKaart.Location = new Point(0, 0);
            rechtsFrieslandKaart.BackColor = Color.Transparent;
            rechtsFrieslandKaart.Controls.Add(rechtsGelderlandKaart);

            rechtsGelderlandKaart.Location = new Point(0, 0);
            rechtsGelderlandKaart.BackColor = Color.Transparent;
            rechtsGelderlandKaart.Controls.Add(rechtsGroningenKaart);

            rechtsGroningenKaart.Location = new Point(0, 0);
            rechtsGroningenKaart.BackColor = Color.Transparent;
            rechtsGroningenKaart.Controls.Add(rechtsLimburgKaart);

            rechtsLimburgKaart.Location = new Point(0, 0);
            rechtsLimburgKaart.BackColor = Color.Transparent;
            rechtsLimburgKaart.Controls.Add(rechtsNoordbKaart);

            rechtsNoordbKaart.Location = new Point(0, 0);
            rechtsNoordbKaart.BackColor = Color.Transparent;
            rechtsNoordbKaart.Controls.Add(rechtsNoordhKaart);

            rechtsNoordhKaart.Location = new Point(0, 0);
            rechtsNoordhKaart.BackColor = Color.Transparent;
            rechtsNoordhKaart.Controls.Add(rechtsOverijsselKaart);

            rechtsOverijsselKaart.Location = new Point(0, 0);
            rechtsOverijsselKaart.BackColor = Color.Transparent;
            rechtsOverijsselKaart.Controls.Add(rechtsUtrechtKaart);

            rechtsUtrechtKaart.Location = new Point(0, 0);
            rechtsUtrechtKaart.BackColor = Color.Transparent;
            rechtsUtrechtKaart.Controls.Add(rechtsZeelandKaart);

            rechtsZeelandKaart.Location = new Point(0, 0);
            rechtsZeelandKaart.BackColor = Color.Transparent;
            rechtsZeelandKaart.Controls.Add(rechtsZuidhKaart);

            rechtsZuidhKaart.Location = new Point(0, 0);
            rechtsZuidhKaart.BackColor = Color.Transparent;
            rechtsZuidhKaart.Controls.Add(rechtsOutlineKaart);

            rechtsOutlineKaart.Location = new Point(0, 0);
            rechtsOutlineKaart.BackColor = Color.Transparent;
        }


//-----------------------------------------------------------------------------------------------------------------------
        private void kaartTekenen(string columnName, DataTable table, string zijde)
        {
            Dictionary<ProvincieEnum, int> provincieScore2 = new Dictionary<ProvincieEnum, int>();

            for (int provincieIndex = 0; provincieIndex < Constants.aantalProvincies; provincieIndex++)
            {
                var huidigeProvincieScore = Convert.ToInt32(table.Rows[provincieIndex][columnName]);
                var provincie = (ProvincieEnum)provincieIndex;
                provincieScore2[provincie] = huidigeProvincieScore;
            }

            var drentheScore = provincieScore2[ProvincieEnum.Drenthe];
            var flevolandScore = provincieScore2[ProvincieEnum.Flevoland];
            var frieslandScore = provincieScore2[ProvincieEnum.Friesland];
            var gelderlandScore = provincieScore2[ProvincieEnum.Gelderland];
            var groningenScore = provincieScore2[ProvincieEnum.Groningen];
            var limburgScore = provincieScore2[ProvincieEnum.Limburg];
            var noordBrabantScore = provincieScore2[ProvincieEnum.NoordBrabant];
            var noordHollandScore = provincieScore2[ProvincieEnum.NoordHolland];
            var overijsselScore = provincieScore2[ProvincieEnum.Overijssel];
            var utrechtScore = provincieScore2[ProvincieEnum.Utrecht];
            var zeelandScore = provincieScore2[ProvincieEnum.Zeeland];
            var zuidHollandScore = provincieScore2[ProvincieEnum.ZuidHolland];

            var maximum = drentheScore;
            var minimum = drentheScore;

            for (int count = 1; count < Constants.aantalProvincies; count++)
            {
                maximum = Calculator.Maximum(maximum, Convert.ToInt32(table.Rows[count][columnName]));
                minimum = Calculator.Minimum(minimum, Convert.ToInt32(table.Rows[count][columnName]));
            }


            var newDrentheScore = Calculator.Difference(minimum, maximum, drentheScore);
            var newflevolandScore = Calculator.Difference(minimum, maximum, flevolandScore);
            var newfrieslandScore = Calculator.Difference(minimum, maximum, frieslandScore);
            var newgelderlandScore = Calculator.Difference(minimum, maximum, gelderlandScore);
            var newgroningenScore = Calculator.Difference(minimum, maximum, groningenScore);
            var newlimburgScore = Calculator.Difference(minimum, maximum, limburgScore);
            var newnoordBrabantScore = Calculator.Difference(minimum, maximum, noordBrabantScore);
            var newnoordHollandScore = Calculator.Difference(minimum, maximum, noordHollandScore);
            var newoverijsselScore = Calculator.Difference(minimum, maximum, overijsselScore);
            var newutrechtScore = Calculator.Difference(minimum, maximum, utrechtScore);
            var newzeelandScore = Calculator.Difference(minimum, maximum, zeelandScore);
            var newzuidHollandScore = Calculator.Difference(minimum, maximum, zuidHollandScore);

            System.Resources.ResourceManager resourceManager = Properties.Resources.ResourceManager;

            var drentheObj = resourceManager.GetObject("DR" + newDrentheScore);
            var flevolandObj = resourceManager.GetObject("FL" + newflevolandScore);
            var frieslandObj = resourceManager.GetObject("FR" + newfrieslandScore);
            var gelderlandObj = resourceManager.GetObject("GL" + newgelderlandScore);
            var groningenObj = resourceManager.GetObject("GR" + newgroningenScore);
            var limburgObj = resourceManager.GetObject("LB" + newlimburgScore);
            var noordbObj = resourceManager.GetObject("NB" + newnoordBrabantScore);
            var noordhObj = resourceManager.GetObject("NH" + newnoordHollandScore);
            var overijsselObj = resourceManager.GetObject("OV" + newoverijsselScore);
            var utrechtObj = resourceManager.GetObject("UT" + newutrechtScore);
            var zeelandObj = resourceManager.GetObject("ZL" + newzeelandScore);
            var zuidhObj = resourceManager.GetObject("ZH" + newzuidHollandScore);

            if (zijde == "rechts")
                RechterKaart(drentheObj, flevolandObj, frieslandObj, gelderlandObj, groningenObj, limburgObj, noordbObj, noordhObj, overijsselObj, utrechtObj, zeelandObj, zuidhObj);
            else if (zijde == "links")
                LinkerKaart(drentheObj, flevolandObj, frieslandObj, gelderlandObj, groningenObj, limburgObj, noordbObj, noordhObj, overijsselObj, utrechtObj, zeelandObj, zuidhObj);

        }

        private void LinkerKaart(object drentheObj, object flevolandObj, object frieslandObj, object gelderlandObj, object groningenObj, object limburgObj, object noordbObj, object noordhObj, object overijsselObj, object utrechtObj, object zeelandObj, object zuidhObj)
        {
            linksDrentheKaart.Image = ((System.Drawing.Bitmap)(drentheObj));
            linksFlevolandKaart.Image = ((System.Drawing.Bitmap)(flevolandObj));
            linksFrieslandKaart.Image = ((System.Drawing.Bitmap)(frieslandObj));
            linksGelderlandKaart.Image = ((System.Drawing.Bitmap)(gelderlandObj));
            linksGroningenKaart.Image = ((System.Drawing.Bitmap)(groningenObj));
            linksLimburgKaart.Image = ((System.Drawing.Bitmap)(limburgObj));
            linksNoordbKaart.Image = ((System.Drawing.Bitmap)(noordbObj));
            linksNoordhKaart.Image = ((System.Drawing.Bitmap)(noordhObj));
            linksOverijsselKaart.Image = ((System.Drawing.Bitmap)(overijsselObj));
            linksUtrechtKaart.Image = ((System.Drawing.Bitmap)(utrechtObj));
            linksZeelandKaart.Image = ((System.Drawing.Bitmap)(zeelandObj));
            linksZuidhKaart.Image = ((System.Drawing.Bitmap)(zuidhObj));
        }

        private void RechterKaart(object drentheObj, object flevolandObj, object frieslandObj, object gelderlandObj, object groningenObj, object limburgObj, object noordbObj, object noordhObj, object overijsselObj, object utrechtObj, object zeelandObj, object zuidhObj)
        {
            rechtsDrentheKaart.Image = ((System.Drawing.Bitmap)(drentheObj));
            rechtsFlevolandKaart.Image = ((System.Drawing.Bitmap)(flevolandObj));
            rechtsFrieslandKaart.Image = ((System.Drawing.Bitmap)(frieslandObj));
            rechtsGelderlandKaart.Image = ((System.Drawing.Bitmap)(gelderlandObj));
            rechtsGroningenKaart.Image = ((System.Drawing.Bitmap)(groningenObj));
            rechtsLimburgKaart.Image = ((System.Drawing.Bitmap)(limburgObj));
            rechtsNoordbKaart.Image = ((System.Drawing.Bitmap)(noordbObj));
            rechtsNoordhKaart.Image = ((System.Drawing.Bitmap)(noordhObj));
            rechtsOverijsselKaart.Image = ((System.Drawing.Bitmap)(overijsselObj));
            rechtsUtrechtKaart.Image = ((System.Drawing.Bitmap)(utrechtObj));
            rechtsZeelandKaart.Image = ((System.Drawing.Bitmap)(zeelandObj));
            rechtsZuidhKaart.Image = ((System.Drawing.Bitmap)(zuidhObj));
        }

        //-----------------------------------------------------------------------------------------------------------------------
        private void UpdateGrid(string misdrijf)
        {
            SqlConnection dbConnection = new SqlConnection(Constants.connectionString);
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY p.prov_naam, m.misdrijfnaam, c.tot_regis_mis), m.misdrijfnaam,c.tot_regis_mis, p.prov_naam
                                                        FROM crimi as c, provincie as p, misdrijf as m
                                                        WHERE c.prov_id = p.prov_id
                                                        AND c.misdrijf_id = m.misdrijf_id
                                                        AND c.periode LIKE '2015%'
                                                        AND level = 'B'
                                                        AND p.prov_naam != 'Niet in te delen'
                                                        AND m.misdrijfnaam LIKE '" + misdrijf + "%'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            kaartTekenen("tot_regis_mis", table, "links");
        }

            private void AlleMisdrijven_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(Constants.connectionString);
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY  p.prov_naam, c.tot_regis_mis DESC, m.misdrijfnaam), m.misdrijfnaam, c.tot_regis_mis, p.prov_naam
                                                        FROM misdrijf as m, provincie as p, crimi as c
                                                        WHERE m.misdrijf_id = c.misdrijf_id
                                                        AND p.prov_id = c.prov_id
                                                        AND c.periode LIKE '2015%'
                                                        AND p.prov_naam != 'Niet in te delen'
                                                        AND m.misdrijf_id = '0'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            kaartTekenen("tot_regis_mis", table, "links");
        }

        private void UpdateGridEthniciteit(string meegegevenEthiniciteit)
        {
            SqlConnection dbConnection = new SqlConnection(Constants.connectionString);
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY p.prov_naam, a." + meegegevenEthiniciteit + " DESC), a." + meegegevenEthiniciteit + @", p.prov_naam
                                                                        FROM afkomst as a, provincie as p
                                                                        WHERE a.periode LIKE '2015%'
                                                                        AND p.prov_id = a.prov_id
                                                                        ORDER BY a.autoch DESC", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            kaartTekenen(meegegevenEthiniciteit, table, "rechts");
        }


//-----------------------------------------------------------------------------------------------------------------------
        private void Vermogensmisdrijven_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "1 Vermogensmisdrijven";
            UpdateGrid(misdrijf);
        }

        private void Vernielingen_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "2 Vernielingen, misdr.openb.orde/gezag";
            UpdateGrid(misdrijf);
        }

        private void GeweldEnSeks_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "3 Gewelds- en seksuele misdrijven";
            UpdateGrid(misdrijf);
        }

        private void WvSr_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "4 Misdrijven WvSr (overig)";
            UpdateGrid(misdrijf);
        }

        private void Verkeer_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "5 Verkeersmisdrijven";
            UpdateGrid(misdrijf);
        }

        private void Drugs_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "6 Drugsmisdrijven";
            UpdateGrid(misdrijf);
        }

        private void Wapen_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "7 (Vuur)wapenmisdrijven";
            UpdateGrid(misdrijf);
        }

        private void OverigeWetten_CheckedChanged(object sender, EventArgs e)
        {
            string misdrijf = "9 Misdrijven overige wetten";
            UpdateGrid(misdrijf);
        }


        //------------------------------------------------------------------------------------------
        private void Autochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "autoch";
            UpdateGridEthniciteit(Ethnicity);
        }

        private void TotAllochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "tot_alloch";
            UpdateGridEthniciteit(Ethnicity);
        }

        private void WestAllochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "w_alloch";
            UpdateGridEthniciteit(Ethnicity);
        }

        private void NonWestAllochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "nw_alloch";
            UpdateGridEthniciteit(Ethnicity);
        }


        //------------------------------------------------------------------------------------------
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoofdschermForm form1 = new HoofdschermForm();
            form1.Show();
        }

        private void linksHeleKaart_Click(object sender, EventArgs e)
        {

        }

        private void uitlegKnop_Click(object sender, EventArgs e)
        {
            Tutorial form4 = new Tutorial();
            form4.ShowDialog();
        }

    }
}
