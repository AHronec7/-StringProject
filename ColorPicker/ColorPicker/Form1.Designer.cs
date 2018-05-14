namespace ColorPicker
{
    partial class ColorPicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.OrangeLabel = new System.Windows.Forms.Label();
            this.YellowButton = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.PurpleLabel = new System.Windows.Forms.Label();
            this.IndigoLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A color ";
            // 
            // RedLabel
            // 
            this.RedLabel.BackColor = System.Drawing.Color.Red;
            this.RedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedLabel.Location = new System.Drawing.Point(12, 59);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(69, 23);
            this.RedLabel.TabIndex = 1;
            this.RedLabel.Click += new System.EventHandler(this.RedLabel_Click);
            // 
            // OrangeLabel
            // 
            this.OrangeLabel.BackColor = System.Drawing.Color.Orange;
            this.OrangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrangeLabel.Location = new System.Drawing.Point(140, 59);
            this.OrangeLabel.Name = "OrangeLabel";
            this.OrangeLabel.Size = new System.Drawing.Size(68, 23);
            this.OrangeLabel.TabIndex = 2;
            this.OrangeLabel.Click += new System.EventHandler(this.OrangeLabel_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowButton.Location = new System.Drawing.Point(273, 60);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(57, 23);
            this.YellowButton.TabIndex = 3;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // GreenLabel
            // 
            this.GreenLabel.BackColor = System.Drawing.Color.Chartreuse;
            this.GreenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLabel.Location = new System.Drawing.Point(389, 60);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(64, 23);
            this.GreenLabel.TabIndex = 4;
            this.GreenLabel.Click += new System.EventHandler(this.GreenLabel_Click);
            // 
            // BlueLabel
            // 
            this.BlueLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BlueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLabel.Location = new System.Drawing.Point(506, 60);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(67, 24);
            this.BlueLabel.TabIndex = 5;
            this.BlueLabel.Click += new System.EventHandler(this.BlueLabel_Click);
            // 
            // PurpleLabel
            // 
            this.PurpleLabel.BackColor = System.Drawing.Color.Purple;
            this.PurpleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurpleLabel.Location = new System.Drawing.Point(744, 59);
            this.PurpleLabel.Name = "PurpleLabel";
            this.PurpleLabel.Size = new System.Drawing.Size(61, 25);
            this.PurpleLabel.TabIndex = 6;
            this.PurpleLabel.Click += new System.EventHandler(this.PurpleLabel_Click);
            // 
            // IndigoLabel
            // 
            this.IndigoLabel.BackColor = System.Drawing.Color.Indigo;
            this.IndigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndigoLabel.Location = new System.Drawing.Point(622, 60);
            this.IndigoLabel.Name = "IndigoLabel";
            this.IndigoLabel.Size = new System.Drawing.Size(67, 24);
            this.IndigoLabel.TabIndex = 7;
            this.IndigoLabel.Click += new System.EventHandler(this.IndigoLabel_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorTextBox.Location = new System.Drawing.Point(298, 140);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.ReadOnly = true;
            this.ColorTextBox.Size = new System.Drawing.Size(142, 20);
            this.ColorTextBox.TabIndex = 8;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 197);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.IndigoLabel);
            this.Controls.Add(this.PurpleLabel);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.OrangeLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.label1);
            this.Name = "ColorPicker";
            this.Text = "Colors ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label OrangeLabel;
        private System.Windows.Forms.Label YellowButton;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label PurpleLabel;
        private System.Windows.Forms.Label IndigoLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
    }
}

