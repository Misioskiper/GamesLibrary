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
        private List<Game> _gamesList;

        public MainForm()
        {
            InitializeComponent();
            _gamesList = new List<Game>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();
            newGameForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
