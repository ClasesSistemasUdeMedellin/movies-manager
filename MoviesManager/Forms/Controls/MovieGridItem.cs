using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesManager.Forms.Controls
{
    public partial class MovieGridItem : UserControl
    {

        public Image Image
        {
            get { return pictureBoxMovieImage.Image; }
            set { pictureBoxMovieImage.Image = value; }
        }

        public string Title
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }

        public string Description
        {
            get { return textBoxDescription.Text; }
            set { textBoxDescription.Text = value; }
        }

        public MovieGridItem()
        {
            InitializeComponent();
        }

        private void panelActions_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                    Color.Black, 0, ButtonBorderStyle.Solid,
                                    SystemColors.ActiveBorder, 1, ButtonBorderStyle.Solid,
                                    Color.Black, 0, ButtonBorderStyle.Solid,
                                    Color.Black, 0, ButtonBorderStyle.Solid);
        }
    }
}
