using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UI
{
    public partial class CurrencyExchange : Form
    {
        SqlConnection sqlConnection;
        DateTime date = new DateTime(2020, 12, 4);

        public CurrencyExchange()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label6.Visible) label6.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [TABLE] (Name, Price, Type, Date)VALUES(@Name, @Price, @Type, @Date)", sqlConnection);
                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Price", textBox3.Text);
                command.Parameters.AddWithValue("Date", date);
                if (radioButton1.Checked)
                {
                    command.Parameters.AddWithValue("Type", radioButton1.Text);
                }
                if (radioButton6.Checked)
                {
                    command.Parameters.AddWithValue("Type", radioButton6.Text);
                }
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label6.Visible = true;
                label6.Text = "Проверьте, чтобы все поля были заполнены!";
            }
        }

        private async void CurrencyExchange_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\UI\UI\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//перейти на след. день
        {
            date = date.AddDays(1);
            listBox1.Items.Clear();
            try
            {
                listBox1.Items.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
