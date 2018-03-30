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
        }

        private void eenNaampje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateGrid(string misdrijf)
        {
            SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Github\Project-3-Datasets\Project 3 - Databases App\WindowsFormsApp3\Database for project 3 - Databases.mdf;Integrated Security=True");
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY c.tot_regis_mis DESC, m.misdrijf_naam, p.prov_naam), m.misdrijf_naam,c.tot_regis_mis, p.prov_naam
                                                        FROM crimi as c, provincie as p, misdrijf as m
                                                        WHERE c.prov_id = p.prov_id
                                                        AND c.misdrijf_id = m.misdrijf_id
                                                        AND c.periode LIKE '2015%'
                                                        AND level = 'B'
                                                        AND m.misdrijf_naam LIKE '" + misdrijf + "%'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            eenNaampje.DataSource = table;

        }

        private void UpdateGridEthniciteit(string meegegevenEthiniciteit)
        {
            SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Github\Project-3-Datasets\Project 3 - Databases App\WindowsFormsApp3\Database for project 3 - Databases.mdf;Integrated Security=True");
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY a." + meegegevenEthiniciteit + " DESC, p.prov_naam), a." + meegegevenEthiniciteit + @", p.prov_naam
                                                                        FROM afkomst as a, provincie as p
                                                                        WHERE a.periode LIKE '2015%'
                                                                        AND p.prov_id = a.prov_id
                                                                        ORDER BY a.autoch DESC", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            EthniciteitGrid.DataSource = table;
        }

        private void AlleMisdrijven_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Github\Project-3-Datasets\Project 3 - Databases App\WindowsFormsApp3\Database for project 3 - Databases.mdf;Integrated Security=True");
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY c.tot_regis_mis DESC, m.misdrijf_naam, p.prov_naam), m.misdrijf_naam, c.tot_regis_mis, p.prov_naam
                                                                    FROM misdrijf as m, provincie as p, crimi as c
                                                                    WHERE m.misdrijf_id = c.misdrijf_id
                                                                    AND p.prov_id = c.prov_id
                                                                    AND c.periode LIKE '2015%'
                                                                    AND m.misdrijf_id = '0'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            eenNaampje.DataSource = table;

        }

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

        private void autochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "autoch";
            UpdateGridEthniciteit(Ethnicity);
        }
        
        private void totAllochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "tot_alloch";
            UpdateGridEthniciteit(Ethnicity);
        }

        private void westAllochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "w_alloch";
            UpdateGridEthniciteit(Ethnicity);
        }

        private void nonWestAllochtonen_CheckedChanged(object sender, EventArgs e)
        {
            string Ethnicity = "nw_alloch";
            UpdateGridEthniciteit(Ethnicity);
        }


    }
}
