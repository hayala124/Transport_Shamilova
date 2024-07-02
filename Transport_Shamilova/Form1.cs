using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Shamilova
{
    public partial class Form1 : Form
    {
        internal static string connection = "Data Source=HAYALA;Initial Catalog=Transport;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAvtorization_Click(object sender, EventArgs e)
        {
            FormAvtorization form = new FormAvtorization();
            form.ShowDialog();

        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelContacts.Visible = true;
        }

        private void аToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoute form = new FormRoute();
            form.ShowDialog();
        }

        private void путиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPath formPath = new FormPath();
            formPath.ShowDialog();
        }
    }
}
