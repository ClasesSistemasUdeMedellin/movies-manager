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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripMainWindow.SuspendLayout();
            this.toolStripMainWIndow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainWindow
            // 
            this.menuStripMainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMainWindow.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainWindow.Name = "menuStripMainWindow";
            this.menuStripMainWindow.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMainWindow.Size = new System.Drawing.Size(1114, 24);
            this.menuStripMainWindow.TabIndex = 0;
            this.menuStripMainWindow.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addMovieToolStripMenuItem.Text = "Add movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // toolStripMainWIndow
            // 
            this.toolStripMainWIndow.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripMainWIndow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddMovie});
            this.toolStripMainWIndow.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainWIndow.Name = "toolStripMainWIndow";
            this.toolStripMainWIndow.Size = new System.Drawing.Size(1114, 57);
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanelGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 369);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanelGrid
            // 
            this.tableLayoutPanelGrid.AutoScroll = true;
            this.tableLayoutPanelGrid.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelGrid.ColumnCount = 3;
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrid.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGrid.Name = "tableLayoutPanelGrid";
            this.tableLayoutPanelGrid.RowCount = 1;
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGrid.Size = new System.Drawing.Size(1114, 369);
            this.tableLayoutPanelGrid.TabIndex = 0;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripMainWIndow);
            this.Controls.Add(this.menuStripMainWindow);
            this.MainMenuStrip = this.menuStripMainWindow;
            this.MinimumSize = new System.Drawing.Size(1130, 0);
            this.Name = "MainWindowForm";
            this.Text = "Movies Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.menuStripMainWindow.ResumeLayout(false);
            this.menuStripMainWindow.PerformLayout();
            this.toolStripMainWIndow.ResumeLayout(false);
            this.toolStripMainWIndow.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMainWindow;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addMovieToolStripMenuItem;
        private ToolStrip toolStripMainWIndow;
        private ToolStripButton toolStripButtonAddMovie;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelGrid;
    }
}