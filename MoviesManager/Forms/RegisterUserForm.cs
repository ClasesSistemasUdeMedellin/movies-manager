using MoviesManager.DataAccess;
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
    public partial class RegisterUserForm : Form
    {
        private MainWindowForm _mainWindow;

        public RegisterUserForm(MainWindowForm mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = textBoxUsername.Text;
                string name = textBoxName.Text;
                string email = textBoxEmail.Text;
                string password = textBoxPassword.Text;

                try
                {
                    _mainWindow.MovieManager.RegisterUser(username, password, name, email);
                    MessageBox.Show($"User {username} successfully registered", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (DuplicatedUsernameException ex)
                {
                    MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxUsername.Text))
            {
                e.Cancel = true;
                textBoxUsername.Focus();
                errorProviderRegisterForm.SetError(textBoxUsername, "Username should not be empty");
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxName.Text))
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProviderRegisterForm.SetError(textBoxName, "Name should not be empty");
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProviderRegisterForm.SetError(textBoxPassword, "Password should not be empty");
            }
        }

        private void textBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProviderRegisterForm.SetError(textBoxConfirmPassword, "Password confirmation should be the same as password");
            }
        }
    }
}
