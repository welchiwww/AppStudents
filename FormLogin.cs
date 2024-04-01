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

namespace AppStudents_DB
{
    public partial class FormLogin : Form
    {
        DataBase dataBase = new DataBase();
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxLogin.MaxLength = 20;
            textBoxPassword.MaxLength = 20;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user_login = textBoxLogin.Text;
            var user_password = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string loginQuery = $"select ID_user, user_login, user_password from Accounts where user_login='{user_login}' and user_password='{user_password}'";

            SqlCommand commandLogin = new SqlCommand(loginQuery, dataBase.getConnection());

            adapter.SelectCommand = commandLogin;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация прошла успешно.", "Уведомление!");
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверно введены данные!", "Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister frm_Register = new FormRegister();
            frm_Register.Show();
            this.Hide();
        }
    }
}
