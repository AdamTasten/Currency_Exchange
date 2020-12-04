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
using UI.Properties;

namespace UI
{
    public partial class CurrencyExchange : Form
    {
        string currency = "USD";
        string type = "Покупка";
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
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrWhiteSpace(clientName.Text) ||
                string.IsNullOrEmpty(givenValue.Text) || string.IsNullOrWhiteSpace(givenValue.Text)
               )
            {
                label6.Visible = true;
                label6.Text = "Проверьте, чтобы  поля не были пустыми!";
            }
            else if ((type.Equals("Продажа") && Convert.ToDouble(givenValue.Text) > Convert.ToDouble((string)Settings.Default[currency + "oper"])) ||
                (type.Equals("Покупка") && Convert.ToDouble(gotValue.Text) > Convert.ToDouble((string)Settings.Default[currency + "oper"])))
            {
                label6.Visible = true;
                label6.Text = "Проверьте, чтобы значения валюты соответствовали лимитам на операцию!";
            }
            else if (false)
            {
                label6.Visible = true;
                label6.Text = "Вероятно, вы превышаете лимит на день!";
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO [TABLE] (Date, Client, ClientID, Cashier, Type, Currency, Given, Got)VALUES(@Date, @Client, @ClientID, @Cashier, @Type, @Currency, @Given, @Got)", sqlConnection);
                command.Parameters.AddWithValue("Date", date);
                command.Parameters.AddWithValue("Client", clientName.Text);
                command.Parameters.AddWithValue("ClientID", userID.Text);
                command.Parameters.AddWithValue("Cashier", cashierName.Text);
                command.Parameters.AddWithValue("Type", type);
                command.Parameters.AddWithValue("Currency", currency);
                command.Parameters.AddWithValue("Given", givenValue.Text);
                command.Parameters.AddWithValue("Got", gotValue.Text);
                //if (toBuyRB.Checked)
                //{
                //    command.Parameters.AddWithValue("Type", toBuyRB.Text);
                //}
                //if (toSellRB.Checked)
                //{
                //    command.Parameters.AddWithValue("Type", toSellRB.Text);
                //}

                await command.ExecuteNonQueryAsync();
            }
        }

        private async void CurrencyExchange_Load(object sender, EventArgs e)
        {
            
            try
            {
                dateBox.Items.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\UI\UI\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                await sqlConnection.OpenAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            dateBox.Items.Clear();
            try
            {
                dateBox.Items.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void givenValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (currency)
                {
                    case "USD":
                        if (toBuyRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(givenValue.Text) / Convert.ToDouble(Settings.Default["USDBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(Settings.Default["USDSell"].ToString()) * Convert.ToDouble(givenValue.Text)).ToString();
                        }
                        break;
                    case "EUR":
                        if (toBuyRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(givenValue.Text) / Convert.ToDouble(Settings.Default["EURBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(Settings.Default["EURSell"].ToString()) * Convert.ToDouble(givenValue.Text)).ToString();
                        }
                        break;
                    case "RUB":
                        if (toBuyRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(givenValue.Text) / Convert.ToDouble(Settings.Default["RUBBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(Settings.Default["RUBSell"].ToString()) * Convert.ToDouble(givenValue.Text)).ToString();
                        }
                        break;
                }
            }
            catch
            {

            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (currency)
                {
                    case "USD":
                        if (toBuyRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) * Convert.ToDouble(Settings.Default["USDBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) / Convert.ToDouble(Settings.Default["USDSell"].ToString())).ToString();
                        }
                        break;
                    case "EUR":
                        if (toBuyRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) * Convert.ToDouble(Settings.Default["EURBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) / Convert.ToDouble(Settings.Default["EURSell"].ToString())).ToString();
                        }
                        break;
                    case "RUB":
                        if (toBuyRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) * Convert.ToDouble(Settings.Default["RUBBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) / Convert.ToDouble(Settings.Default["RUBSell"].ToString())).ToString();
                        }
                        break;
                }
            }
            catch 
            {
            
            }

        }

        private void usdRB_CheckedChanged(object sender, EventArgs e)
        {
            givenValue.Text = "";
            gotValue.Text = "";
            currency = "USD";
        }

        private void eurRB_CheckedChanged(object sender, EventArgs e)
        {
            givenValue.Text = "";
            gotValue.Text = "";
            currency = "EUR";
        }

        private void rubRB_CheckedChanged(object sender, EventArgs e)
        {
            givenValue.Text = "";
            gotValue.Text = "";
            currency = "RUB";
        }

        private void toBuyRB_CheckedChanged(object sender, EventArgs e)//зануляем поля валют, если выбран новый тип обмена
        {
            givenValue.Text = "";
            gotValue.Text = "";
            type = "Покупка";
        }

        private void toSellRB_CheckedChanged(object sender, EventArgs e)//зануляем поля валют, если выбран новый тип обмена
        {
            givenValue.Text = "";
            gotValue.Text = "";
            type = "Продажа";
        }
    }
}
