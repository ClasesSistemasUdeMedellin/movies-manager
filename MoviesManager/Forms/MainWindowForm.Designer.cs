namespace MoviesManager.Forms
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMainWindow = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainWIndow = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddMovie = new System.Windows.Forms.ToolStripButton();
            this.menuStripMainWindow.SuspendLayout();
            this.toolStripMainWIndow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainWindow
            // 
            this.menuStripMainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMainWindow.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainWindow.Name = "menuStripMainWindow";
            this.menuStripMainWindow.Size = new System.Drawing.Size(914, 28);
            this.menuStripMainWindow.TabIndex = 0;
            this.menuStripMainWindow.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addMovieToolStripMenuItem.Text = "Add movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // toolStripMainWIndow
            // 
            this.toolStripMainWIndow.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripMainWIndow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddMovie});
            this.toolStripMainWIndow.Location = new System.Drawing.Point(0, 28);
            this.toolStripMainWIndow.Name = "toolStripMainWIndow";
            this.toolStripMainWIndow.Size = new System.Drawing.Size(914, 57);
            this.toolStripMainWIndow.TabIndex = 1;
            this.toolStripMainWIndow.Text = "toolStrip1";
            // 
            // toolStripButtonAddMovie
            // 
            this.toolStripButtonAddMovie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddMovie.Image = global::MoviesManager.Resources.AddMovie;
            this.toolStripButtonAddMovie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddMovie.Name = "toolStripButtonAddMovie";
            this.toolStripButtonAddMovie.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonAddMovie.Text = "toolStripButton1";
            this.toolStripButtonAddMovie.ToolTipText = "Add movie";
            this.toolStripButtonAddMovie.Click += new System.EventHandler(this.toolStripButtonAddMovie_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.toolStripMainWIndow);
            this.Controls.Add(this.menuStripMainWindow);
            this.MainMenuStrip = this.menuStripMainWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindowForm";
            this.Text = "Movies Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.menuStripMainWindow.ResumeLayout(false);
            this.menuStripMainWindow.PerformLayout();
            this.toolStripMainWIndow.ResumeLayout(false);
            this.toolStripMainWIndow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMainWindow;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addMovieToolStripMenuItem;
        private ToolStrip toolStripMainWIndow;
        private ToolStripButton toolStripButtonAddMovie;
    }
}