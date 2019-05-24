using bibliotekaGier.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotekaGier
{
    public partial class MainForm : Form
    {
        private Library _library { get; set; }
        public MainForm()
        {
            InitializeComponent();
            _library = new Library();
            _library.ImportFromFile();
            gamesListBox.DataSource = _library.GetGames();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm(_library);
            newGameForm.ShowDialog();
            _library = newGameForm.Library;
            gamesListBox.DataSource = null;
            gamesListBox.DataSource = _library.GetGames();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var gameToDelete = (Game)gamesListBox.SelectedItem;
            _library.RemoveGame(gameToDelete);
            gamesListBox.DataSource = null;
            gamesListBox.DataSource = _library.GetGames();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _library.SaveGamesToFile();
            MessageBox.Show("Czy chcesz wyjść?", "Wyjście", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
