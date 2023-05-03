using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

            LoadData();

        }
        private void LoadData()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            myConnection.Open();

            string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox2.Text == "Эксмо")
            {
                textBox3.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE publishing_house = 'Эксмо'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox2.Text == "АСТ")
            {
                textBox3.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE publishing_house = 'АСТ'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox2.Text == "Харвест")
            {
                textBox3.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE publishing_house = 'Харвест'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Фридрих Ницше" || textBox3.Text == "Фридрих" || textBox3.Text == "Ницше")
            {
                textBox2.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE author = 'Фридрих Ницше'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox3.Text == "Сунь-цзы" || textBox3.Text == "Сунь" || textBox3.Text == "цзы")
            {
                textBox2.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE author = 'Сунь-цзы'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox3.Text == "Луций Анней Сенека" || textBox3.Text == "Луций" || textBox3.Text == "Анней" || textBox3.Text == "Сенека")
            {
                textBox2.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE author = 'Луций Анней Сенека'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox3.Text == "Жан Бодрийяр" || textBox3.Text == "Жан" || textBox3.Text == "Бодрийяр")
            {
                textBox2.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE author = 'Жан Бодрийяр'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox3.Text == "Артур Шопенгауэр" || textBox3.Text == "Артур" || textBox3.Text == "Шопенгауэр")
            {
                textBox2.Clear();
                textBox4.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE author = 'Артур Шопенгауэр'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "По ту сторону добра и зла" || textBox4.Text == "По ту сторону" || textBox4.Text == "добра и зла")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE book_name = 'По ту сторону добра и зла'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox4.Text == "Искусство войны" || textBox4.Text == "Искусство" || textBox4.Text == "войны")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE book_name = 'Искусство войны'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox4.Text == "Нравственные письма к Луцилию" || textBox4.Text == "Нравственные" || textBox4.Text == "Нравственные письма" || textBox4.Text == "письма к Луцилию")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE book_name = 'Нравственные письма к Луцилию'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox4.Text == "Общество потребления: его мифы и структуры" || textBox4.Text == "Общество потребления" || textBox4.Text == "мифы" || textBox4.Text == "структуры")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE book_name = 'Общество потребления: его мифы и структуры'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else
                if (textBox4.Text == "Мир как воля и представление" || textBox4.Text == "Мир" || textBox4.Text == "Мир как воля" || textBox4.Text == "представление")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.mdb;";

                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myConnection.Open();

                string query = "SELECT book_name, author, publishing_house, number_of_pages, price FROM books WHERE book_name = 'Мир как воля и представление'";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "По ту сторону добра и зла" || textBox4.Text == "По ту сторону" || textBox4.Text == "добра и зла")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
            else
                if (textBox4.Text == "Искусство войны" || textBox4.Text == "Искусство" || textBox4.Text == "войны")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();

            }
            else
                if (textBox4.Text == "Нравственные письма к Луцилию" || textBox4.Text == "Нравственные" || textBox4.Text == "Нравственные письма" || textBox4.Text == "письма к Луцилию")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();

            }
            else
                if (textBox4.Text == "Общество потребления: его мифы и структуры" || textBox4.Text == "Общество потребления" || textBox4.Text == "мифы" || textBox4.Text == "структуры")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                Form7 form7 = new Form7();
                form7.Show();
                this.Hide();

            }
            else
                if (textBox4.Text == "Мир как воля и представление" || textBox4.Text == "Мир" || textBox4.Text == "Мир как воля" || textBox4.Text == "представление")
            {
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1.Rows.Clear();

                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();

            }
        }
    }
}
