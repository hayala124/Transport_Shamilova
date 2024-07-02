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
using System.Windows.Forms.VisualStyles;
using Transport_Shamilova.TransportDataSetTableAdapters;

namespace Transport_Shamilova
{
    public partial class FormAddRoute : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;

        public FormAddRoute()
        {
            InitializeComponent();
        }

        private void FormAddRoute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Path". При необходимости она может быть перемещена или удалена.
            this.pathTableAdapter.Fill(this.transportDataSet.Path);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.TypeOfTransport". При необходимости она может быть перемещена или удалена.
            this.typeOfTransportTableAdapter.Fill(this.transportDataSet.TypeOfTransport);

            
            connection = new SqlConnection(@"Data Source=HAYALA;Initial Catalog=Transport;Integrated Security=True");
            connection.Open();

            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Соединение с базой данных не установлено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tabPage_1();
            }

            if (GlobalVariablesClass.PagesFormRoute == 1)
            {
                this.tabControl1.SelectedTab = this.tabPageAddRoute;
            }
            else if (GlobalVariablesClass.PagesFormRoute == 2)
            {
                this.tabControl1.SelectedTab = this.tabPageEditRoute;
            }
            else
            {
                this.tabControl1.SelectedTab = this.tabPageDeleteRoute;
            }

        }

        // Метод для добавления данных в бд.
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            SqlCommand addCommand = new SqlCommand("INSERT INTO Route (NumberOfRoute, NumberOfPassengersPerDay, NumberOfStopsOnTheWay," +
                "NumberOfCarsOnRoute, PathID, TypeOfTransportID) VALUES (@NumberOfRoute, @NumberOfPassengersPerDay, @NumberOfStopsOnTheWay, @NumberOfCarsOnRoute, @PathID, @TypeOfTransportID)", connection);

            addWithValue(addCommand);

            if (addCommand.ExecuteNonQuery() == 1)
            {
                var dialogResult = MessageBox.Show("Данные успешно добавились!\nХотите продолжить добавление маршрута?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    labelNumberRoute.Text = (int.Parse(labelNumberRoute.Text) + 1).ToString();
                    numericUpDownPassengers.Value = 0;
                    numericUpDownStops.Value = 2;
                    numericUpDownCars.Value = 0;
                    comboBoxPath.SelectedIndex = 0;
                    comboBoxTypeOfTransport.SelectedIndex = 0;
                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Возникла ошибка при добавлении нового маршрута!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для удаления данныхиз бд по номеру маршрута.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string routeNumber = textBoxNumberRoute.Text;
            try
            {
                using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Route WHERE NumberOfRoute = @NumberOfRoute", connection))
                {
                    var deleteResult = MessageBox.Show($"Вы подтверждаете, что хотите удалить маршрут с номером {routeNumber}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (deleteResult == DialogResult.Yes)
                    {
                        deleteCommand.Parameters.AddWithValue("@NumberOfRoute", int.Parse(routeNumber));

                        if (deleteCommand.ExecuteNonQuery() == 1)
                        {
                            var dialogResult = MessageBox.Show($"Маршрут с номером {routeNumber} успешно удален\nХотите продолжить удаление?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            routeTableAdapter.Fill(this.transportDataSet.Route);
                            if (dialogResult == DialogResult.Yes)
                            {
                                textBoxNumberRoute.Clear();
                            }
                            else
                            {
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Маршрут с номером {routeNumber} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при удалении маршрута: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для ограничения ввода символов, не относящихся к управляющему символу или же к цифрам.
        private void textBoxRouteNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxRouteNumber(sender, e);
        }

        private void textBoxNumberRouteEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxRouteNumber(sender, e);
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SqlCommand editCommand = new SqlCommand("UPDATE Route SET " +
                "NumberOfPassengersPerDay = @NumberOfPassengersPerDay, " +
                "NumberOfStopsOnTheWay = @NumberOfStopsOnTheWay," +
                "NumberOfCarsOnRoute = @NumberOfCarsOnRoute, PathID = @PathID, " +
                "TypeOfTransportID = @TypeOfTransportID" +
                "WHERE NumberOfRoute = @NumberOfRoute", connection);

            routeTableAdapter.Fill(this.transportDataSet.Route);

           // dataGridViewRouteEdit.DataSource = transportDataSet.Tables[0];

            if (editCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно обновились!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                routeTableAdapter.Fill(this.transportDataSet.Route);
            }
            else
            {
                MessageBox.Show("Возникла ошибка при добавлении нового маршрута!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //SqlDataAdapter dataAdapter = new SqlDataAdapter(
            //   "SELECT Route.NumberOfRoute as 'Номер маршрута', " +
            //   "Route.NumberOfPassengersPerDay as 'Количество пассажиров в день'," +
            //   "Route.NumberOfStopsOnTheWay as 'Количество остановок в пути', " +
            //   "Route.NumberOfCarsOnRoute as 'Количество машин на маршруте', " +
            //   "TypeOfTransport.NameTransport as 'Вид транспорта', Path.StartingPoint as 'Начальный пункт' " +
            //   "FROM Route " +
            //   "Join TypeOfTransport " +
            //   "on Route.TypeOfTransportID = TypeOfTransport.IdTypeOfTransport " +
            //   "Join Path " +
            //   "on Route.PathID = Path.IdPath", connection);

            //DataSet dataSet = new DataSet();
            //dataAdapter.Fill(dataSet);

            ////dataGridViewRouteEdit.DataSource = dataSet.Tables[0];
            //DataTable table = transportDataSet.Tables[1]; // Получаем таблицу из DataSet
            ////DataRow row = table.Rows[10]; // Берем первую строку (первый маршрут)

            //int passengers = Convert.ToInt32(row["NumberOfPassengersPerDay"]); // Получаем текущее количество пассажиров
            //int updatedPassengers = passengers + (int)(passengers * 0.1); // Увеличиваем количество пассажиров на 10%

            //row["NumberOfPassengersPerDay"] = updatedPassengers; // Обновляем количество пассажиров в строке

            //// Теперь обновляем данные в базе данных
            //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            //dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand(); // Получаем команду обновления
            //dataAdapter.Update(dataSet, "Route"); // Обновляем данные в базе данных
        }

        private void addWithValue(SqlCommand command)
        {
            command.Parameters.AddWithValue("NumberOfRoute", int.Parse(labelNumberRoute.Text));
            command.Parameters.AddWithValue("NumberOfPassengersPerDay", int.Parse(numericUpDownPassengers.Value.ToString()));
            command.Parameters.AddWithValue("NumberOfStopsOnTheWay", int.Parse(numericUpDownStops.Value.ToString()));
            command.Parameters.AddWithValue("NumberOfCarsOnRoute", int.Parse(numericUpDownCars.Value.ToString()));
            command.Parameters.AddWithValue("PathID", comboBoxPath.SelectedValue.ToString());
            command.Parameters.AddWithValue("TypeOfTransportID", comboBoxTypeOfTransport.SelectedValue.ToString());
        }

        private void tabPage_1()
        {
            // Запрос для поиска максимального значения NumberOfRoute.
            SqlCommand getMaxCommand = new SqlCommand("SELECT MAX(NumberOfRoute) FROM [Route]", connection);
            object result = getMaxCommand.ExecuteScalar();

            if (result != null && !string.IsNullOrEmpty(result.ToString()))
            {
                int maxRouteNumber = Convert.ToInt32(result) + 1;
                labelNumberRoute.Text = maxRouteNumber.ToString();
            }
            else
            {
                labelNumberRoute.Text = "1";
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabPage_1();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
               "SELECT Route.NumberOfRoute as 'Номер маршрута', " +
               "Route.NumberOfPassengersPerDay as 'Количество пассажиров в день'," +
               "Route.NumberOfStopsOnTheWay as 'Количество остановок в пути', " +
               "Route.NumberOfCarsOnRoute as 'Количество машин на маршруте', " +
               "TypeOfTransport.NameTransport as 'Вид транспорта', Path.StartingPoint as 'Начальный пункт' " +
               "FROM Route " +
               "Join TypeOfTransport " +
               "on Route.TypeOfTransportID = TypeOfTransport.IdTypeOfTransport " +
               "Join Path " +
               "on Route.PathID = Path.IdPath", connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridViewRouteEdit.DataSource = dataSet.Tables[0];
            }
        }
    }
}
