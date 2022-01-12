namespace ChuckForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokseBtn = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokseBtn
            // 
            this.getJokseBtn.Location = new System.Drawing.Point(78, 30);
            this.getJokseBtn.Name = "getJokseBtn";
            this.getJokseBtn.Size = new System.Drawing.Size(113, 35);
            this.getJokseBtn.TabIndex = 0;
            this.getJokseBtn.Text = "Get Joke";
            this.getJokseBtn.UseVisualStyleBackColor = true;
            this.getJokseBtn.Click += new System.EventHandler(this.getJokseBtn_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(38, 83);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(227, 288);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get a joke, I dare you";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.getJokseBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokseBtn;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

