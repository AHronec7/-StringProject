namespace CSVReader
{
    partial class Form1
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
            this.AverageListBox = new System.Windows.Forms.ListBox();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AverageListBox
            // 
            this.AverageListBox.FormattingEnabled = true;
            this.AverageListBox.Location = new System.Drawing.Point(12, 23);
            this.AverageListBox.Name = "AverageListBox";
            this.AverageListBox.Size = new System.Drawing.Size(268, 277);
            this.AverageListBox.TabIndex = 0;
            // 
            // ScoreButton
            // 
            this.ScoreButton.Location = new System.Drawing.Point(369, 62);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(75, 23);
            this.ScoreButton.TabIndex = 1;
            this.ScoreButton.Text = "Get Scores";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(369, 174);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 348);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.AverageListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AverageListBox;
        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

