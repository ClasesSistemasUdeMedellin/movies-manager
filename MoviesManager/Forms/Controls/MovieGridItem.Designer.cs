namespace MoviesManager.Forms.Controls
{
    partial class MovieGridItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieGridItem));
            this.pictureBoxMovieImage = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.toolTipMovieItem = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovieImage)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMovieImage
            // 
            this.pictureBoxMovieImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMovieImage.Image = global::MoviesManager.Resources.defaultimage;
            this.pictureBoxMovieImage.InitialImage = global::MoviesManager.Resources.defaultimage;
            this.pictureBoxMovieImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMovieImage.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxMovieImage.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxMovieImage.Name = "pictureBoxMovieImage";
            this.pictureBoxMovieImage.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovieImage.TabIndex = 0;
            this.pictureBoxMovieImage.TabStop = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(109, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(251, 18);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "Aquí va el título de la película";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Location = new System.Drawing.Point(109, 25);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(251, 79);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonSearch);
            this.panelActions.Controls.Add(this.buttonView);
            this.panelActions.Controls.Add(this.buttonReview);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 107);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(363, 38);
            this.panelActions.TabIndex = 3;
            this.panelActions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActions_Paint);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.Image = global::MoviesManager.Resources.search;
            this.buttonSearch.Location = new System.Drawing.Point(275, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(37, 31);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonView.Image = global::MoviesManager.Resources.view;
            this.buttonView.Location = new System.Drawing.Point(232, 3);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(37, 31);
            this.buttonView.TabIndex = 1;
            this.buttonView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonReview
            // 
            this.buttonReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReview.Image = global::MoviesManager.Resources.review;
            this.buttonReview.Location = new System.Drawing.Point(318, 3);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(37, 31);
            this.buttonReview.TabIndex = 0;
            this.buttonReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReview.UseVisualStyleBackColor = true;
            // 
            // MovieGridItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.pictureBoxMovieImage);
            this.MinimumSize = new System.Drawing.Size(363, 145);
            this.Name = "MovieGridItem";
            this.Size = new System.Drawing.Size(363, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovieImage)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxMovieImage;
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private Panel panelActions;
        private Button buttonReview;
        private ToolTip toolTipMovieItem;
        private Button buttonView;
        private Button buttonSearch;
    }
}
