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
        public Library Library { get; set; }

        public NewGameForm(Library lib)
        {
            InitializeComponent();
            Library = lib;
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO1
                string gameTitle = titleTextBox.Text;
                decimal gamePrice = decimal.Parse(priceTextBox.Text);
                string gameDescription = descriptionTextBox.Text;
                int gameAge = int.Parse(ageTextBox.Text);
                Game game = new Game(gameTitle, gamePrice, gameDescription, gameAge);
                Library.AddGame(game);
                this.Hide();
            }
            catch (Exception ex)
            {
                //TODO2
                MessageBox.Show("Coś poszło nie tak", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
