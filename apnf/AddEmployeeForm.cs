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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        
            try
            {
                connector.OpenConnection();
                string command_string = "insert into employees (firstname,secondname,thirdname,role) values (@first,@second,@third,@role)";
                MySqlCommand mySqlCommand = new MySqlCommand(command_string, connector.GetConection());
                mySqlCommand.Parameters.Add("@first", MySqlDbType.VarChar).Value = FirstTextBox.Text;
                mySqlCommand.Parameters.Add("@second", MySqlDbType.VarChar).Value = SecondTextBox.Text;
                mySqlCommand.Parameters.Add("@third", MySqlDbType.VarChar).Value = ThirdTextBox.Text;
                mySqlCommand.Parameters.Add("@role", MySqlDbType.VarChar).Value = RoleTextBox.Text;
                
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно создана", "Успешно");
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так!", "Ошибка!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connector.CloseConnection();
            }

        }
    }
}
