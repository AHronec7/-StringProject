namespace TelephoneUnformat
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
            this.label1 = new System.Windows.Forms.Label();
            this.UnformatButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UnformatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a telephone number in the format (XXX)-XXX-XXXX and I will unformat it for " +
    "you";
            // 
            // UnformatButton
            // 
            this.UnformatButton.Location = new System.Drawing.Point(79, 123);
            this.UnformatButton.Name = "UnformatButton";
            this.UnformatButton.Size = new System.Drawing.Size(75, 23);
            this.UnformatButton.TabIndex = 1;
            this.UnformatButton.Text = "Unformat";
            this.UnformatButton.UseVisualStyleBackColor = true;
            this.UnformatButton.Click += new System.EventHandler(this.UnformatButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(331, 123);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UnformatTextBox
            // 
            this.UnformatTextBox.Location = new System.Drawing.Point(157, 53);
            this.UnformatTextBox.Name = "UnformatTextBox";
            this.UnformatTextBox.Size = new System.Drawing.Size(165, 20);
            this.UnformatTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 178);
            this.Controls.Add(this.UnformatTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UnformatButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UnformatButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox UnformatTextBox;
    }
}

