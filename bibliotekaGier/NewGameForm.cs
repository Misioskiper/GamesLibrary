using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bibliotekaGier.Model;

namespace bibliotekaGier
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            string description = descriptionTextBox.Text;
            string age = ageTextBox.Text;
            Game game = new Game(title, price, description, age);
            this.Hide();
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }
    }
}
