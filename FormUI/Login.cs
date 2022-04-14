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
    public partial class Login : Form
    {
        Card card;
        Person person;
        public Login()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            // Gets card from using citizenship id and pin of card
            card = db.GetCard(idText.Text, Int16.Parse(pinText.Text));
            if (card != null)
            {
                // Gets person using cards' owners' id
                person = db.GetPerson(card.PersonID);
                if(person != null)
                {
                    // if authentication is successfull then it hides this form and shows dashboard of atm 
                    Dashboard d = new Dashboard(card,person);
                    d.Show();
                    this.Hide();
                }
                else
                {
                    warningLabel.Text = "This card does not have an owner.";
                }
            }
            else
            {
                warningLabel.Text = "ID or PIN is invalid.";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
