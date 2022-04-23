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
    public partial class AddPaymentForm : Form
    {
        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            double patch = Convert.ToDouble(PatchNumericUpDown.Text.ToString());

            double fss = patch - ((patch / 100) * 2.9);
            double pfr = patch - ((patch / 100) * 22);
            double foms = patch - ((patch / 100) * 5.1);

            try
            {
                connector.OpenConnection();
                string command_string = "insert into payments (employeeid,payment,foundid,payperc) values (@id,@payment,@foundid,@payperc);";
                MySqlCommand mySqlCommand = new MySqlCommand(command_string, connector.GetConection());
                mySqlCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = IDTextBox.Text;
                mySqlCommand.Parameters.Add("@payment", MySqlDbType.Double).Value = fss;
                mySqlCommand.Parameters.Add("@foundid", MySqlDbType.Int32).Value = 1;
                mySqlCommand.Parameters.Add("@payperc", MySqlDbType.VarChar).Value = "2,9%";

                string command_string_1 = "insert into payments (employeeid,payment,foundid,payperc) values (@id,@payment,@foundid,@payperc);";
                MySqlCommand mySqlCommand_1 = new MySqlCommand(command_string_1, connector.GetConection());
                mySqlCommand_1.Parameters.Add("@id", MySqlDbType.Int32).Value = IDTextBox.Text;
                mySqlCommand_1.Parameters.Add("@payment", MySqlDbType.Double).Value = pfr;
                mySqlCommand_1.Parameters.Add("@foundid", MySqlDbType.Int32).Value = 2;
                mySqlCommand_1.Parameters.Add("@payperc", MySqlDbType.VarChar).Value = "22%";

                string command_string_2 = "insert into payments (employeeid,payment,foundid,payperc) values (@id,@payment,@foundid,@payperc);";
                MySqlCommand mySqlCommand_2 = new MySqlCommand(command_string_2, connector.GetConection());
                mySqlCommand_2.Parameters.Add("@id", MySqlDbType.Int32).Value = IDTextBox.Text;
                mySqlCommand_2.Parameters.Add("@payment", MySqlDbType.Double).Value = foms;
                mySqlCommand_2.Parameters.Add("@foundid", MySqlDbType.Int32).Value = 3;
                mySqlCommand_2.Parameters.Add("@payperc", MySqlDbType.VarChar).Value = "5,1%";

                if (mySqlCommand.ExecuteNonQuery() == 1 && mySqlCommand_1.ExecuteNonQuery() == 1 && mySqlCommand_2.ExecuteNonQuery() == 1)
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
