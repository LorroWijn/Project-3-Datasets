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
    public partial class HoofdschermForm : Form
    {
        public HoofdschermForm()
        {
            InitializeComponent();
        }

        private void afkomstBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\loren\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database for project 3 - Databases.mdf;Integrated Security=True");
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT DISTINCT m.misdrijf_naam, m.misdrijf_id
                                                        FROM misdrijf as m
                                                        WHERE level = 'B'
                                                        ORDER BY m.misdrijf_naam", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            misdrijfNamen.DataSource = table;
        }

        private void CrimiVSGrond_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrimiVSAfkomst_Click(object sender, EventArgs e)
        {

        }

        private void misdrijfNamen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = (sender as DataGridView).Rows[e.RowIndex];
                String misdrijf = (row.Cells["misdrijf_naam"].Value.ToString());
                misdrijf = misdrijf.Substring(0, misdrijf.IndexOf(" "));
                UpdateGrid(misdrijf);
            }

        }

        private void UpdateGrid(string misdrijf)
        {
            SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\loren\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database for project 3 - Databases.mdf;Integrated Security=True");
            dbConnection.Open();
            SqlCommand queryMisdaden = new SqlCommand(@"SELECT ROW_NUMBER() OVER(ORDER BY c.tot_regis_mis DESC, m.misdrijf_naam, p.prov_naam), m.misdrijf_naam,c.tot_regis_mis, p.prov_naam
                                                        FROM crimi as c, provincie as p, misdrijf as m
                                                        WHERE c.prov_id = p.prov_id
                                                        AND c.misdrijf_id = m.misdrijf_id
                                                        AND c.periode LIKE '2016%'
                                                        AND level = 'B'
                                                        AND m.misdrijf_naam LIKE '"+misdrijf+"%'", dbConnection);
            SqlDataReader reader = queryMisdaden.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            eenNaampje.DataSource = table;

        }
    }
}
