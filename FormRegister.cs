using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace AppStudents_DB
{
    public partial class FormRegister : Form
    {
        DataBase dataBase = new DataBase();
        public FormRegister()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            textBoxLogin.MaxLength = 20;
            textBoxPassword.MaxLength = 20;

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            var user_login = textBoxLogin.Text;
            var user_password = textBoxPassword.Text;
            dataBase.openConnection();
            string registerQuery = $"insert into Accounts(user_login,user_password) values ('{user_login}','{user_password}')";
            SqlCommand commandRegister = new SqlCommand(registerQuery, dataBase.getConnection());

            if(commandRegister.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно.", "Уведомление!");
                FormLogin frm_login = new FormLogin();
                this.Hide();
                frm_login.Show();
            }
            else
            {
                MessageBox.Show("Ошибка в создании аккаунта!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.closeConnection();
        }
        public Boolean checkUserExist()
        {
            var user_login = textBoxLogin.Text;
            var user_password = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryCheck = $"select * from Accounts where user_login='{user_login}' and '{user_password}'";
            SqlCommand commandCheck = new SqlCommand(queryCheck, dataBase.getConnection());

            adapter.SelectCommand = commandCheck;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0 )
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
