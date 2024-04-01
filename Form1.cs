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
using System.Windows.Forms.VisualStyles;
using static AppStudents_DB.Data;


namespace AppStudents_DB
{
    public partial class Form1 : Form
    {
        DataBase dataBaseCon = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBaseCon.openConnection();

            string getTables = "select TABLE_NAME " +
                "from INFORMATION_SCHEMA.TABLES where TABLE_NAME != 'Accounts' and TABLE_NAME != 'sysdiagrams'";
            SqlCommand commandGetTables = new SqlCommand(getTables, dataBaseCon.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = commandGetTables;
            adapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBoxTables.Items.Add(dataTable.Rows[i][0].ToString());
            }
            dataBaseCon.closeConnection();
        }


        private TextBox[] returnTextBoxes()
        {
            TextBox[] textBoxes =
            {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5
            };
            return textBoxes;
        }

        private Label[] returnLabels()
        {
            Label[] labels =
            {
                label1,
                label2,
                label3,
                label4,
                label5
            };
            return labels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox[] textBoxes = returnTextBoxes();
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = false;
            }
        }


        private void refreshTable()
        {
            Label[] labels = returnLabels();
            TextBox[] textBoxes = returnTextBoxes();

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = false;
                textBoxes[i].Visible = false;
            }

            dataBaseCon.openConnection();
            string selectQuery = $"SELECT * FROM {comboBoxTables.SelectedItem}";
            SqlCommand commandSelect = new SqlCommand(selectQuery, dataBaseCon.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = commandSelect;
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;


            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                labels[i].Text = DictionaryData[dataTable.Columns[i].ColumnName];
                labels[i].Visible = true;
                textBoxes[i].Visible = true;
                textBoxes[i].Text = "";
            }
            dataBaseCon.closeConnection();


        }
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
            dataGridView1.Enabled = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            TextBox[] textBoxes = returnTextBoxes();
            dataBaseCon.openConnection();

            SqlCommand commandSelect = new SqlCommand($"select * from {comboBoxTables.SelectedItem}", dataBaseCon.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = commandSelect;
            adapter.Fill(dataTable);
            
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                textBoxes[i].Text = dataTable.Rows[e.RowIndex][i].ToString();
            }
            dataBaseCon.closeConnection();
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            dataBaseCon.openConnection();

            TextBox[] textBoxes = returnTextBoxes();
            SqlCommand query = new SqlCommand($"select * from {comboBoxTables.SelectedItem}", dataBaseCon.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable currentTable = new DataTable();

            adapter.SelectCommand = query;
            adapter.Fill(currentTable);

            string[] values = new string[currentTable.Columns.Count];
            string[] columns = new string[currentTable.Columns.Count];

            for (int i = 0; i < currentTable.Columns.Count; i++)
            {
                values[i] = "'" + textBoxes[i].Text.Trim() + "'";
                columns[i] = currentTable.Columns[i].ColumnName;
            }

            string newRow = String.Join(",", values);
            newRow.TrimEnd(',');
            newRow.Remove(0, textBox1.Text.Length + 3);

            string insertColumns = String.Join(",", columns);
            insertColumns.TrimEnd(',');
            insertColumns.Remove(0, currentTable.Columns[0].ColumnName.Length + 1);

            query = new SqlCommand($@"insert into {comboBoxTables.SelectedItem}({insertColumns})
                                            values ({newRow})", dataBaseCon.getConnection());


            try
            {
                
                query.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлена запись!", "Успех");
                refreshTable();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBaseCon.closeConnection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataBaseCon.openConnection();

            TextBox[] textBoxes = returnTextBoxes();
            SqlCommand query = new SqlCommand($"select * from {comboBoxTables.SelectedItem}", dataBaseCon.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = query;
            adapter.Fill(dataTable);

            query = new SqlCommand($"delete from {comboBoxTables.SelectedItem} " +
                                            $"where {dataTable.Columns[0].ColumnName} = {dataTable.Rows[index][0]}", dataBaseCon.getConnection());
            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно.", "Успех!");
                refreshTable();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при удалении!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonEdit_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = returnTextBoxes();

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
            }
        }

        private void radioButtonView_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = returnTextBoxes();

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = false;
            }
        }

        private void buttonChangeRow_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataBaseCon.openConnection();

            TextBox[] textBoxes = returnTextBoxes();

            SqlCommand cmd = new SqlCommand($"select * from {comboBoxTables.SelectedItem}", dataBaseCon.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            string[] val = new string[dataTable.Columns.Count];
            string[] col = new string[dataTable.Columns.Count];
            string[] rows = new string[dataTable.Columns.Count - 1];

            for (int i = 0; i<val.Length; i++)
            {
                val[i] = "'" + textBoxes[i].Text.Trim() + "'";
                col[i] = dataTable.Columns[i].ColumnName;
            }

            string newRow = String.Join(",", val);
            newRow = newRow.TrimEnd(',');
            newRow = newRow.Remove(0, textBox1.Text.Length + 3);
            val = newRow.Split(',');

            string cols = String.Join(",", col);
            cols = cols.TrimEnd(',');
            cols = cols.Remove(0, dataTable.Columns[0].ColumnName.Length + 1);
            col = cols.Split(',');

            for (int i =0; i < rows.Length; i++)
            {
                rows[i] = col[i] + " = " + val[i];
            }

            newRow = String.Join(",", rows);
            newRow.TrimEnd(',');

            cmd = new SqlCommand($@"update {comboBoxTables.SelectedItem} set {newRow} where {dataTable.Columns[0].ColumnName} = {dataTable.Rows[index][0]}", dataBaseCon.getConnection());

            try
            {
                cmd.ExecuteNonQuery();
                refreshTable();
                MessageBox.Show("Запись была успешно изменена.", "Успех!");
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBaseCon.closeConnection();
        }

        private void buttonProcedureAbsentStudents_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            SqlCommand cmd = new SqlCommand("exec GetAbsentStudents", dataBaseCon.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.Enabled = false;

            Label[] labels = returnLabels();
            TextBox[] textBoxes = returnTextBoxes();

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = false;
                textBoxes[i].Visible = false;
            }
        }

        private void buttonProcedureFailedStudents_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Enabled = false;

            SqlCommand cmd = new SqlCommand("exec GetFailedStudents", dataBaseCon.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.Enabled = false;

            Label[] labels = returnLabels();
            TextBox[] textBoxes = returnTextBoxes();

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = false;
                textBoxes[i].Visible = false;
            }
        }

        private void buttonEnableTrigger_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand("enable trigger UpdatePersonalInfoModifiedDate on PersonalInfo", dataBaseCon.getConnection());

            dataBaseCon.openConnection();
            cmd.ExecuteNonQuery();
            dataBaseCon.closeConnection();
            MessageBox.Show("Триггер был включен!", "Уведомление");
        }

        private void buttonDisableTrigger_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand("disable trigger UpdatePersonalInfoModifiedDate on PersonalInfo", dataBaseCon.getConnection());

            dataBaseCon.openConnection();
            cmd.ExecuteNonQuery();
            dataBaseCon.closeConnection();
            MessageBox.Show("Триггер был выключен!", "Уведомление");
        }
    }
}
