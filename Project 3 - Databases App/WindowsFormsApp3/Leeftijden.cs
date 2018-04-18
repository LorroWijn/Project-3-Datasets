﻿using System;
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
    public partial class Leeftijden : Form
    {
        public Leeftijden()
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
        private void UpdateGrid(string misdrijf)
        {
            SqlConnection dbConnection = new SqlConnection(DataSource.dataSource);
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY p.prov_naam, m.misdrijf_naam, c.tot_regis_mis), m.misdrijf_naam,c.tot_regis_mis, p.prov_naam
                                                        FROM crimi as c, provincie as p, misdrijf as m
                                                        WHERE c.prov_id = p.prov_id
                                                        AND c.misdrijf_id = m.misdrijf_id
                                                        AND c.periode LIKE '2010%'
                                                        AND level = 'B'
                                                        AND p.prov_naam != 'Niet in te delen'
                                                        AND m.misdrijf_naam LIKE '" + misdrijf + "%'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            Dictionary<ProvincieLinksEnum, int> provincieScore2 = new Dictionary<ProvincieLinksEnum, int>();

            for (int provincieIndex = 0; provincieIndex < Constants.aantalProvincies; provincieIndex++)
            {
                var huidigeProvincieScore = Convert.ToInt32(table.Rows[provincieIndex]["tot_regis_mis"]);
                var provincie = (ProvincieLinksEnum)provincieIndex;
                provincieScore2[provincie] = huidigeProvincieScore;
            }

            var drentheScore = provincieScore2[ProvincieLinksEnum.Drenthe];
            var flevolandScore = provincieScore2[ProvincieLinksEnum.Flevoland];
            var frieslandScore = provincieScore2[ProvincieLinksEnum.Friesland];
            var gelderlandScore = provincieScore2[ProvincieLinksEnum.Gelderland];
            var groningenScore = provincieScore2[ProvincieLinksEnum.Groningen];
            var limburgScore = provincieScore2[ProvincieLinksEnum.Limburg];
            var noordBrabantScore = provincieScore2[ProvincieLinksEnum.NoordBrabant];
            var noordHollandScore = provincieScore2[ProvincieLinksEnum.NoordHolland];
            var overijsselScore = provincieScore2[ProvincieLinksEnum.Overijssel];
            var utrechtScore = provincieScore2[ProvincieLinksEnum.Utrecht];
            var zeelandScore = provincieScore2[ProvincieLinksEnum.Zeeland];
            var zuidHollandScore = provincieScore2[ProvincieLinksEnum.ZuidHolland];

            var maximum = drentheScore;
            var minimum = drentheScore;

            for (int count = 1; count < Constants.aantalProvincies; count++)
            {
                maximum = Calculator.Maximum(maximum, Convert.ToInt32(table.Rows[count]["tot_regis_mis"]));
                minimum = Calculator.Minimum(minimum, Convert.ToInt32(table.Rows[count]["tot_regis_mis"]));
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

            linksDrentheKaart.Image = Properties.Resources.DR02;
            linksFlevolandKaart.Image = Properties.Resources.FL01;
            linksFrieslandKaart.Image = Properties.Resources.FR01;
            linksGelderlandKaart.Image = Properties.Resources.GL01;
            linksGroningenKaart.Image = Properties.Resources.GR01;
            linksLimburgKaart.Image = Properties.Resources.LB01;
            linksNoordbKaart.Image = Properties.Resources.NB01;
            linksNoordhKaart.Image = Properties.Resources.NH01;
            linksOverijsselKaart.Image = Properties.Resources.OV01;
            linksUtrechtKaart.Image = Properties.Resources.UT01;
            linksZeelandKaart.Image = Properties.Resources.ZL01;
            linksZuidhKaart.Image = Properties.Resources.ZH01;

        }

        private void AlleMisdrijven_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(DataSource.dataSource);
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY c.tot_regis_mis DESC, m.misdrijf_naam, p.prov_naam), m.misdrijf_naam, c.tot_regis_mis, p.prov_naam
                                                        FROM misdrijf as m, provincie as p, crimi as c
                                                        WHERE m.misdrijf_id = c.misdrijf_id
                                                        AND p.prov_id = c.prov_id
                                                        AND c.periode LIKE '2015%'
                                                        AND p.prov_naam != 'Niet in te delen'
                                                        AND m.misdrijf_id = '0'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            Dictionary<ProvincieLinksEnum, int> provincieScore2 = new Dictionary<ProvincieLinksEnum, int>();

            for (int provincieIndex = 0; provincieIndex < Constants.aantalProvincies; provincieIndex++)
            {
                var huidigeProvincieScore = Convert.ToInt32(table.Rows[provincieIndex]["tot_regis_mis"]);
                var provincie = (ProvincieLinksEnum)provincieIndex;
                provincieScore2[provincie] = huidigeProvincieScore;
            }

            var drentheScore = provincieScore2[ProvincieLinksEnum.Drenthe];
            var flevolandScore = provincieScore2[ProvincieLinksEnum.Flevoland];
            var frieslandScore = provincieScore2[ProvincieLinksEnum.Friesland];
            var gelderlandScore = provincieScore2[ProvincieLinksEnum.Gelderland];
            var groningenScore = provincieScore2[ProvincieLinksEnum.Groningen];
            var limburgScore = provincieScore2[ProvincieLinksEnum.Limburg];
            var noordBrabantScore = provincieScore2[ProvincieLinksEnum.NoordBrabant];
            var noordHollandScore = provincieScore2[ProvincieLinksEnum.NoordHolland];
            var overijsselScore = provincieScore2[ProvincieLinksEnum.Overijssel];
            var utrechtScore = provincieScore2[ProvincieLinksEnum.Utrecht];
            var zeelandScore = provincieScore2[ProvincieLinksEnum.Zeeland];
            var zuidHollandScore = provincieScore2[ProvincieLinksEnum.ZuidHolland];

            var maximum = drentheScore;
            var minimum = drentheScore;

            for (int count = 1; count < Constants.aantalProvincies; count++)
            {
                maximum = Calculator.Maximum(maximum, Convert.ToInt32(table.Rows[count]["tot_regis_mis"]));
                minimum = Calculator.Minimum(minimum, Convert.ToInt32(table.Rows[count]["tot_regis_mis"]));
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

            linksDrentheKaart.Image = Properties.Resources.DR02;
            linksFlevolandKaart.Image = Properties.Resources.FL03;
            linksFrieslandKaart.Image = Properties.Resources.FR01;
            linksGelderlandKaart.Image = Properties.Resources.GL01;
            linksGroningenKaart.Image = Properties.Resources.GR01;
            linksLimburgKaart.Image = Properties.Resources.LB01;
            linksNoordbKaart.Image = Properties.Resources.NB01;
            linksNoordhKaart.Image = Properties.Resources.NH01;
            linksOverijsselKaart.Image = Properties.Resources.OV01;
            linksUtrechtKaart.Image = Properties.Resources.UT01;
            linksZeelandKaart.Image = Properties.Resources.ZL01;
            linksZuidhKaart.Image = Properties.Resources.ZH01;
        }

        private void UpdateGridLeeftijd(string meegegevenLeeftijd)
        {
            SqlConnection dbConnection = new SqlConnection(DataSource.dataSource);
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY p.prov_naam, l." + meegegevenLeeftijd + " DESC), l." + meegegevenLeeftijd + @", p.prov_naam
                                                                    FROM leeftijd as l, provincie as p
                                                                    WHERE l.periode LIKE '2015%'
                                                                    AND p.prov_id = l.prov_id", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            Dictionary<ProvincieRechtsEnum, int> provincieScore2 = new Dictionary<ProvincieRechtsEnum, int>();

            for (int provincieIndex = 0; provincieIndex < Constants.aantalProvincies; provincieIndex++)
            {
                var huidigeProvincieScore = Convert.ToInt32(table.Rows[provincieIndex][meegegevenLeeftijd]);
                var provincie = (ProvincieRechtsEnum)provincieIndex;
                provincieScore2[provincie] = huidigeProvincieScore;
            }

            var drentheScore = provincieScore2[ProvincieRechtsEnum.Drenthe];
            var flevolandScore = provincieScore2[ProvincieRechtsEnum.Flevoland];
            var frieslandScore = provincieScore2[ProvincieRechtsEnum.Friesland];
            var gelderlandScore = provincieScore2[ProvincieRechtsEnum.Gelderland];
            var groningenScore = provincieScore2[ProvincieRechtsEnum.Groningen];
            var limburgScore = provincieScore2[ProvincieRechtsEnum.Limburg];
            var noordBrabantScore = provincieScore2[ProvincieRechtsEnum.NoordBrabant];
            var noordHollandScore = provincieScore2[ProvincieRechtsEnum.NoordHolland];
            var overijsselScore = provincieScore2[ProvincieRechtsEnum.Overijssel];
            var utrechtScore = provincieScore2[ProvincieRechtsEnum.Utrecht];
            var zeelandScore = provincieScore2[ProvincieRechtsEnum.Zeeland];
            var zuidHollandScore = provincieScore2[ProvincieRechtsEnum.ZuidHolland];

            var maximum = drentheScore;
            var minimum = drentheScore;

            for (int count = 1; count < Constants.aantalProvincies; count++)
            {
                maximum = Calculator.Maximum(maximum, Convert.ToInt32(table.Rows[count][meegegevenLeeftijd]));
                minimum = Calculator.Minimum(minimum, Convert.ToInt32(table.Rows[count][meegegevenLeeftijd]));
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

            rechtsDrentheKaart.Image = Properties.Resources.DR08;
            rechtsFlevolandKaart.Image = Properties.Resources.FL01;
            rechtsFrieslandKaart.Image = Properties.Resources.FR01;
            rechtsGelderlandKaart.Image = Properties.Resources.GL01;
            rechtsGroningenKaart.Image = Properties.Resources.GR01;
            rechtsLimburgKaart.Image = Properties.Resources.LB01;
            rechtsNoordbKaart.Image = Properties.Resources.NB01;
            rechtsNoordhKaart.Image = Properties.Resources.NH01;
            rechtsOverijsselKaart.Image = Properties.Resources.OV01;
            rechtsUtrechtKaart.Image = Properties.Resources.UT01;
            rechtsZeelandKaart.Image = Properties.Resources.ZL01;
            rechtsZuidhKaart.Image = Properties.Resources.ZH01;


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


//-----------------------------------------------------------------------------------------------------
        private void xJongerDan5_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "jongerdan5";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x5tot10_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van5tot10";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x10tot15_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van10tot15";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x15tot20_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van15tot20";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x20tot25_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van20tot25";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x25tot45_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van25tot45";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x45tot65_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van45tot65";
            UpdateGridLeeftijd(leeftijdMens);
        }

        private void x65tot80_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "van65tot80";
            UpdateGridLeeftijd(leeftijdMens);
        }
        
        private void xOuderDan80_CheckedChanged(object sender, EventArgs e)
        {
            string leeftijdMens = "ouderdan80";
            UpdateGridLeeftijd(leeftijdMens);
        }


//-----------------------------------------------------------------------------------------------------
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoofdschermForm form1 = new HoofdschermForm();
            form1.Show();
        }

        private void uitlegKnop_Click(object sender, EventArgs e)
        {

        }
    }








}
