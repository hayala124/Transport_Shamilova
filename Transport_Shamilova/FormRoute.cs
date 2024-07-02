using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Transport_Shamilova
{
    public partial class FormRoute : Form
    {
        private SqlConnection connection = null;
        public FormRoute()
        {
            InitializeComponent();
        }

        // Экспорт данных в Excel.
        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Маршруты";

            // Установка заголовков столбцов.
            worksheet.Cells[1, 1] = dataGridViewRoute.Columns[0].HeaderCell.Value;
            worksheet.Cells[1, 2] = dataGridViewRoute.Columns[1].HeaderCell.Value;
            worksheet.Cells[1, 3] = dataGridViewRoute.Columns[2].HeaderCell.Value;
            worksheet.Cells[1, 4] = dataGridViewRoute.Columns[3].HeaderCell.Value;
            worksheet.Cells[1, 5] = dataGridViewRoute.Columns[4].HeaderCell.Value;

            // Применение жирного шрифта к заголовкам столбцов.
            worksheet.Range["A1:E1"].Font.Bold = true;

            for (int j = 2; j < dataGridViewRoute.RowCount + 1; j++)
            {
                worksheet.Cells[j, 1] = dataGridViewRoute[0, j - 2].Value;
                worksheet.Cells[j, 2] = dataGridViewRoute[1, j - 2].Value;
                worksheet.Cells[j, 3] = dataGridViewRoute[2, j - 2].Value;
                worksheet.Cells[j, 4] = dataGridViewRoute[3, j - 2].Value;
                worksheet.Cells[j, 5] = dataGridViewRoute[4, j - 2].Value;
            }

            worksheet.Range["A1:E1" + (dataGridViewRoute.Rows.Count + 1).ToString()].ColumnWidth = 15;
            application.Visible = true;

        }

        private void FormRoute_Load(object sender, EventArgs e)
        {
            if (GlobalVariablesClass.CurrentUserRole == "admin")
            {
                buttonAddRoute.Enabled = true;
                buttonEditRoute.Enabled = true;
                buttonDeleteRoute.Enabled = true;
            }
            connection = new SqlConnection(@"Data Source=HAYALA;Initial Catalog=Transport;Integrated Security=True");
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Route.NumberOfRoute as 'Номер маршрута', " +
                "Route.NumberOfPassengersPerDay as 'Количество пассажиров в день'," +
                "Route.NumberOfStopsOnTheWay as 'Количество остановок в пути', " +
                "Route.NumberOfCarsOnRoute as 'Количество машин на маршруте', " +
                "TypeOfTransport.NameTransport as 'Вид транспорта'" +
                "FROM Route " +
                "Join TypeOfTransport " +
                "on Route.TypeOfTransportID = TypeOfTransport.IdTypeOfTransport", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridViewRoute.DataSource = dataSet.Tables[0];
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            GlobalVariablesClass.PagesFormRoute = 1; 
            FormAddRoute formAddRoute = new FormAddRoute();
            formAddRoute.ShowDialog();
            this.Hide();
        }

        private void buttonEditRoute_Click(object sender, EventArgs e)
        {
            GlobalVariablesClass.PagesFormRoute = 2;
            FormAddRoute formAddRoute = new FormAddRoute();
            formAddRoute.ShowDialog();
            this.Hide();
        }

        private void buttonDeleteRoute_Click(object sender, EventArgs e)
        {
            GlobalVariablesClass.PagesFormRoute = 3;
            FormAddRoute formAddRoute = new FormAddRoute();
            formAddRoute.ShowDialog();
            this.Hide();
        }

        // Метод для фильтрации по Количеству остановок в пути.
        private void textBoxFiltrStops_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = dataGridViewRoute.DataSource as DataTable;

            if (!string.IsNullOrWhiteSpace(textBoxFiltrStops.Text))
            {
                dataTable.DefaultView.RowFilter = $"[Количество остановок в пути] = {textBoxFiltrStops.Text}";
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }

        // Метод для фильтрации по Номеру маршрута с помощью comboBox.
        private void comboBoxNumberRouteFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = dataGridViewRoute.DataSource as DataTable;

            switch (comboBoxNumberRouteFiltr.SelectedIndex)
            {
                case 0:
                    dataTable.DefaultView.RowFilter = $"[Номер маршрута] <= 110";
                    break;
                case 1:
                    dataTable.DefaultView.RowFilter = $"[Номер маршрута] >= 110 AND [Номер маршрута] <= 120";
                    break;
                case 2:
                    dataTable.DefaultView.RowFilter = $"[Номер маршрута] >= 120";
                    break;
                case 3:
                    dataTable.DefaultView.RowFilter = "";
                    break;
            }
        }

        private void textBoxFiltrStops_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
