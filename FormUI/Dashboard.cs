using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        Card card;
        Person person;
        DataAccess db = new DataAccess();
        public Dashboard(Card card,Person person)
        {
            InitializeComponent();
            this.card = card;
            this.person = person;
            // Updates labels
            fullInfoLabel.Text = person.FullInfo;
            balanceLabel.Text = card.Balance.ToString();
        }

        // Gets object from database and updates labels
        private void UpdateBinding()
        {
            card = db.GetCard(card.id);
            person = db.GetPerson(person.PersonID);
            fullInfoLabel.Text = person.FullInfo;
            balanceLabel.Text = card.Balance.ToString();
        }

        private void Dashboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

       
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            var input = float.Parse(transactionText.Text);
            // Checks input of textbox
            if (input > card.Balance)
            {
                warningLabel.Text = "You don't have that much money.";
            }
            else
            {
                // Descrements balance and update database and labels
                card.Balance -= input;
                db.UpdateBalance(card.Balance,card.id);
                UpdateBinding();
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var input = float.Parse(transactionText.Text);
            // Increments balance and update database and labels
            card.Balance += input;
            db.UpdateBalance(card.Balance, card.id);
            UpdateBinding();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hides this form and shows login form
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
