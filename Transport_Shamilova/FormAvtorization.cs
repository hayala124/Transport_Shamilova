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

namespace Transport_Shamilova
{
    public partial class FormAvtorization : Form
    {
        public static string CurrentUserRole { get; set; } = "guest";

        public FormAvtorization()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAvtorization_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLogin.Text;
            string passUser = textBoxPassword.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=HAYALA;Initial Catalog=Transport;Integrated Security=True");
            try
            {
                conn.Open();
                string query = "SELECT [IdUser], [Login], [Password] FROM [dbo].[User] WHERE [login] = @login AND [password] = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", loginUser);
                cmd.Parameters.AddWithValue("@password", passUser);

                SqlDataReader reader = cmd.ExecuteReader();

                if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!reader.HasRows)
                {
                    MessageBox.Show("Неправильно введен логин или пароль!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reader.Read())
                    {
                        if (loginUser.ToLower() == "admin")
                        {
                            GlobalVariablesClass.CurrentUserRole = loginUser.ToLower();
                            MessageBox.Show($"Вы успешно вошли как {loginUser}, вам доступны дополнительные права!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Вы успешно вошли, как {loginUser}\n", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Ошибка " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
