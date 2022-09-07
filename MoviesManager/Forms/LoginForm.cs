
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
    }
}