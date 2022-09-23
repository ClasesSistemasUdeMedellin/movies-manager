using MoviesManager.Forms.Controls;
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
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            tableLayoutPanelGrid.RowStyles.Clear();
            tableLayoutPanelGrid.ColumnStyles.Clear();
            tableLayoutPanelGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));
            tableLayoutPanelGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));
            tableLayoutPanelGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));
            for (int r = 0; r < 6; r++)
            {
                tableLayoutPanelGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
                for (int c = 0; c < 3; c++)
                {
                    var item = new MovieGridItem();
                    item.Anchor = AnchorStyles.None;
                    tableLayoutPanelGrid.Controls.Add(item, c, r);
                }
            }
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Enabled = false;
            LoginForm loginForm = new LoginForm(this);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();

            Comment_Movie comment_Movie = new Comment_Movie();
            comment_Movie.ShowDialog();
        }

        public void InitializeUI()
        {
            Enabled = true;
            this.Text =  $"Movie Manager: movies library for {MovieManager.AuthenticatedUser.UserDto.Name}";
        }

        public void ShowAddMovieForm()
        {
            AddMovieForm addMovieForm = new AddMovieForm(this);
            addMovieForm.StartPosition = FormStartPosition.CenterScreen;
            addMovieForm.ShowDialog();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddMovieForm();
        }

        private void toolStripButtonAddMovie_Click(object sender, EventArgs e)
        {
            ShowAddMovieForm();
        }
    }
}
