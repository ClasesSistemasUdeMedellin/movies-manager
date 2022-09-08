using MoviesManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesManager.Forms
{
    public partial class AddMovieForm : Form
    {
        private MainWindowForm _mainWindow;
        public AddMovieForm(MainWindowForm mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listBoxCategories.DataSource = Movie.Categories;
            listBoxCategories.DisplayMember = "Name";

            comboBoxStatus.DataSource = Movie.Statuses;
            comboBoxStatus.DisplayMember = "Name";
        }
    }
}
