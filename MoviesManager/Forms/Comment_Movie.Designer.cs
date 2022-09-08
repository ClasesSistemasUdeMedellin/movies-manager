namespace MoviesManager.Forms
{
    partial class Comment_Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment_Movie));
            this.label1Comment = new System.Windows.Forms.Label();
            this.richTextBox1Comment = new System.Windows.Forms.RichTextBox();
            this.button1Send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1Comment
            // 
            resources.ApplyResources(this.label1Comment, "label1Comment");
            this.label1Comment.Name = "label1Comment";
            this.label1Comment.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1Comment
            // 
            resources.ApplyResources(this.richTextBox1Comment, "richTextBox1Comment");
            this.richTextBox1Comment.Name = "richTextBox1Comment";
            this.richTextBox1Comment.TextChanged += new System.EventHandler(this.richTextBox1Comment_TextChanged);
            // 
            // button1Send
            // 
            resources.ApplyResources(this.button1Send, "button1Send");
            this.button1Send.Name = "button1Send";
            this.button1Send.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1Send);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Comment_Movie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1Comment);
            this.Controls.Add(this.label1Comment);
            this.Name = "Comment_Movie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1Comment;
        private RichTextBox richTextBox1Comment;
        private Button button1Send;
        private Panel panel1;
    }
}