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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrimiVSAfkomst_Click(object sender, EventArgs e)
        {
            Ethniciteit form2 = new Ethniciteit();
            form2.Show();
            this.Hide();
        }

        private void CrimiVSGrond_Click(object sender, EventArgs e)
        {
            Landbouw form2 = new Landbouw();
            form2.Show();
            this.Hide();
        }

        private void crimiVsLeeftijdKnop_Click(object sender, EventArgs e)
        {
            Leeftijden form2 = new Leeftijden();
            form2.Show();
            this.Hide();
        }
    }
}
