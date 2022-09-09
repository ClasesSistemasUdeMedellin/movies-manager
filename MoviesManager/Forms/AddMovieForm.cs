using MoviesManager.DataAccess.Dto;
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

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxTitle.Text))
            {
                e.Cancel = true;
                textBoxTitle.Focus();
                errorProviderAddMovieForm.SetError(textBoxTitle, "Title should not be empty");
            }
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescription.Text))
            {
                e.Cancel = true;
                textBoxDescription.Focus();
                errorProviderAddMovieForm.SetError(textBoxDescription, "Description should not be empty");
            }
        }

        private void listBoxCategories_Validating(object sender, CancelEventArgs e)
        {
            if(listBoxCategories.SelectedIndices.Count == 0)
            {
                e.Cancel= true;
                listBoxCategories.Focus();
                errorProviderAddMovieForm.SetError(listBoxCategories, "At least one category should be selected");            }
        }

        private void comboBoxStatus_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxStatus.SelectedIndex == -1)
            {
                e.Cancel = true;
                comboBoxStatus.Focus();
                errorProviderAddMovieForm.SetError(comboBoxStatus, "A status should be selected");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string title = textBoxTitle.Text;
                string description = textBoxDescription.Text;
                List<CategoryDto>? categories = listBoxCategories.SelectedItems.Cast<CategoryDto>().ToList();
                MovieStatusDto? status = comboBoxStatus.SelectedItem as MovieStatusDto;
                try
                {
                    _mainWindow.MovieManager.AddMovie(title, description, categories, status);
                    MessageBox.Show($"The movie {title} was successfully added to the library", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
