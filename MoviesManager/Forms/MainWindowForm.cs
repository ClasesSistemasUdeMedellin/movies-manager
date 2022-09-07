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
    public partial class MainWindowForm : Form
    {
        public MovieManager MovieManager { get; set; }

        public MainWindowForm(MovieManager movieManager)
        {
            MovieManager = movieManager;
            InitializeComponent();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
        }
    }
}
