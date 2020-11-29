using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrencyExchange сurrencyExchange = new CurrencyExchange();
            сurrencyExchange.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityHistory activityHistory = new ActivityHistory();
            activityHistory.Show();
        }

        private void setLimits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limits limits = new Limits();
            limits.Show();
        }

        private void setRateOfExchange_Click(object sender, EventArgs e)
        {
            this.Hide();
            RateOfExchange rateOfExchange = new RateOfExchange();
            rateOfExchange.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateField_TextChanged(object sender, EventArgs e)
        {
            //dateField.Text = "30.11.2020";
        }
    }
}
