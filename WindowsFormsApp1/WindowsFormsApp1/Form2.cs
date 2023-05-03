using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            myConnection.Open();

            string query = "SELECT * FROM books";

            OleDbCommand command= new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();

            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите строку полностью", "Ошибка");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null
                )
            {
                MessageBox.Show("Введите данные в каждое поле", "Ошибка");
                return;
            }

            string book_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string book_name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string author = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string publishing_house = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string quantity = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string number_of_pages = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string price = dataGridView1.Rows[index].Cells[6].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            myConnection.Open();
            string query = "INSERT INTO books VALUES(" + book_id + ", '" + book_name + "', '" + author + "', '" + publishing_house + "', '" + quantity + "', '" + number_of_pages + "', '" + price + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, myConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка добавления данных", "Ошибка");
            else
                MessageBox.Show("Данные успешно добавлены");

            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите строку полностью", "Ошибка");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            string book_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            myConnection.Open();
            string query = "DELETE FROM books WHERE book_id = " + book_id;
            OleDbCommand dbCommand = new OleDbCommand(query, myConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка удаления данных", "Ошибка");
            else
            {
                MessageBox.Show("Данные успешно удалены");
                dataGridView1.Rows.RemoveAt(index);
            }

            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
