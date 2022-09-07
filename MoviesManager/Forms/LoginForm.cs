
using MoviesManager.Model;

namespace MoviesManager.Forms
{
    public partial class LoginForm : Form
    {
        private MainWindowForm _mainWindow;

        public LoginForm(MainWindowForm mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerForm = new RegisterUserForm(_mainWindow);
            registerForm.StartPosition = FormStartPosition.CenterParent;
            registerForm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = textBoxUser.Text;
                string password = textBoxPassword.Text;

                try
                {
                    _mainWindow.MovieManager.LoginUser(username, password);
                    _mainWindow.InitializeUI();
                    Close();
                }
                catch (InvalidCredentialsException ex)
                {
                    MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxUser_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxUser.Text))
            {
                e.Cancel = true;
                textBoxUser.Focus();
                errorProviderLoginForm.SetError(textBoxUser, "Username should not be empty");
            }
        }

        private void textBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxPassword.Text))
            {
                e.Cancel = true;
                textBoxPassword.Focus();
                errorProviderLoginForm.SetError(textBoxPassword, "Password should not be empty");
            }
        }
    }
}