using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apnf
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            Connector connector = new Connector();

            string LoginQuery = "select * from employees, users where users.id = employees.id and login=@user and password=@password;";

            MySqlCommand sqlCommand1 = new MySqlCommand(LoginQuery, connector.GetConection());
            sqlCommand1.Parameters.Add("@user", MySqlDbType.VarChar).Value = LoginTextBox.Text;
            sqlCommand1.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text;

            MainForm mainForm = new MainForm();
            try
            {
                connector.OpenConnection();
                dataAdapter.SelectCommand = sqlCommand1;
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    mainForm.nameLabel.Text = dataTable.Rows[0]["secondname"].ToString() + " " + dataTable.Rows[0]["firstname"].ToString() + " " + dataTable.Rows[0]["thirdname"].ToString();
                    MessageBox.Show("Добро пожаловать, " + dataTable.Rows[0]["firstname"].ToString() + " " + dataTable.Rows[0]["thirdname"].ToString());

                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность данных");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
            finally
            {
                connector.CloseConnection();
            }
        }
    }
}
