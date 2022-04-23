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
    public partial class MainForm : Form
    {
        void EmployeesLoad()
        {
            Connector connector = new Connector();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from employees;", connector.GetConection());

            try
            {
                connector.OpenConnection();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                dataGridViewEmployees.Columns.Add("ID", "Идетификатор");
                dataGridViewEmployees.Columns.Add("firstname", "Имя");
                dataGridViewEmployees.Columns.Add("secondname", "Фамилия");
                dataGridViewEmployees.Columns.Add("thirdname", "Отчество");
                dataGridViewEmployees.Columns.Add("role", "Должность");
                while (mySqlDataReader.Read())
                {
                    dataGridViewEmployees.Rows.Add(mySqlDataReader["ID"].ToString(), mySqlDataReader["firstname"].ToString(), mySqlDataReader["secondname"].ToString(), mySqlDataReader["thirdname"].ToString(), mySqlDataReader["role"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
            finally
            {
                connector.CloseConnection();
            }

        }

        void PaymentsLoad()
        {
            Connector connector = new Connector();

            MySqlCommand mySqlCommand = new MySqlCommand("select firstname,secondname,thirdname,payment,name,role,payperc from payments,employees,founds where employees.id = payments.employeeid and founds.id = payments.foundid;", connector.GetConection());

            try
            {
                connector.OpenConnection();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                dataGridViewPayments.Columns.Add("firstname", "Имя");
                dataGridViewPayments.Columns.Add("secondname", "Фамилия");
                dataGridViewPayments.Columns.Add("thirdname", "Отчество");
                dataGridViewPayments.Columns.Add("payment", "Размер выплаты");
                dataGridViewPayments.Columns.Add("name", "Фонд");
                dataGridViewPayments.Columns.Add("payperc", "%");
                dataGridViewPayments.Columns.Add("role", "Должность");  
                while (mySqlDataReader.Read())
                {
                    dataGridViewPayments.Rows.Add(mySqlDataReader["firstname"].ToString(), mySqlDataReader["secondname"].ToString(), mySqlDataReader["thirdname"].ToString(), mySqlDataReader["payment"].ToString(), mySqlDataReader["name"].ToString(), mySqlDataReader["payperc"].ToString(), mySqlDataReader["role"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
            finally
            {
                connector.CloseConnection();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            EmployeesLoad();
            PaymentsLoad();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            AddPaymentForm addPaymentForm = new AddPaymentForm();
            addPaymentForm.Show();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.Columns.Remove("ID");
            dataGridViewEmployees.Columns.Remove("firstname");
            dataGridViewEmployees.Columns.Remove("secondname");
            dataGridViewEmployees.Columns.Remove("thirdname");
            dataGridViewEmployees.Columns.Remove("role");
            EmployeesLoad();
        }

        private void UpdatePaymentButton_Click(object sender, EventArgs e)
        {
            dataGridViewPayments.Columns.Remove("firstname");
            dataGridViewPayments.Columns.Remove("secondname");
            dataGridViewPayments.Columns.Remove("thirdname");
            dataGridViewPayments.Columns.Remove("payment");
            dataGridViewPayments.Columns.Remove("name");
            dataGridViewPayments.Columns.Remove("payperc");
            dataGridViewPayments.Columns.Remove("role");
            PaymentsLoad();
        }
    }
}
