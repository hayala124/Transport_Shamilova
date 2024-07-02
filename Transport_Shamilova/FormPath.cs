using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Shamilova
{
    public partial class FormPath : Form
    {
        private SqlConnection connection = null;

        public FormPath()
        {
            InitializeComponent();
        }

        private void FormPath_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=HAYALA;Initial Catalog=Transport;Integrated Security=True");
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Route.NumberOfRoute as 'Номер маршрута', Path.StartingPoint AS 'Начальная точка', " +
                "Path.FinalPoint AS 'Конечная точка', Path.Distance AS 'Дистанция' " +
                "FROM Route " +
                "JOIN Path on Route.PathID = Path.IdPath", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewPath.DataSource = dataSet.Tables[0];

        }

        private void buttonAddPath_Click(object sender, EventArgs e)
        {
            FormAddPath formAddPath = new FormAddPath();
            formAddPath.ShowDialog();
            this.Hide();
        }

        private void buttonEditPath_Click(object sender, EventArgs e)
        {

        }
    }
}
