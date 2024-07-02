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
using System.Windows.Forms.VisualStyles;

namespace Transport_Shamilova
{
    public partial class FormAddPath : Form
    {
        private SqlConnection connection = null;

        public FormAddPath()
        {
            InitializeComponent();
        }

        private void pathBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pathBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void FormAddPath_Load(object sender, EventArgs e)
        {
            this.pathTableAdapter.Fill(this.transportDataSet.Path);

            connection = new SqlConnection(@"Data Source=HAYALA;Initial Catalog=Transport;Integrated Security=True");
            connection.Open();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            //DataRow nRow = transportDataSet.Path.NewRow();
            //nRow[1] = textBoxStartingPoint.Text.ToString();
            //nRow[2] = textBoxFinalPoint.Text.ToString();
            //nRow[3] = numericUpDownDistance.Text.ToString();

            //if (textBoxStartingPoint.Text != "" && textBoxFinalPoint.Text != "")
            //{
            //    this.transportDataSet.Path.Rows.Add(nRow);
            //    tableAdapterManager.UpdateAll(this.transportDataSet);
            //    transportDataSet.Path.AcceptChanges();
            //    MessageBox.Show("Данные успешно сохранены!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{

            //}


            SqlCommand command = new SqlCommand("INSERT INTO Path (StartingPoint, FinalPoint, Distance) VALUES (@StartingPoint, @FinalPoint, @Distance)", connection);

            command.Parameters.AddWithValue("StartingPoint", textBoxStartingPoint.Text);
            command.Parameters.AddWithValue("FinalPoint", textBoxFinalPoint.Text);
            command.Parameters.AddWithValue("Distance", int.Parse(numericUpDownDistance.Value.ToString()));


            if (command.ExecuteNonQuery().ToString() == "1")
            {
                var dialogResult = MessageBox.Show("Данные успешно добавились!\nХотите продолжить добавление пути?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    textBoxStartingPoint.Text = "";
                    textBoxFinalPoint.Text = "";
                    numericUpDownDistance.Value = 0;

                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                var dialogResult = MessageBox.Show("Возникла ошибка при добавлении нового пути!\nХотите попробовать добавить снова?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
        }
    }
}
