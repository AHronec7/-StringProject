namespace MemberConnection
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
            this.LoadFormButton = new System.Windows.Forms.Button();
            this.MemberConversionGrid = new System.Windows.Forms.DataGridView();
            this.OpenFormButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MemberConversionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFormButton
            // 
            this.LoadFormButton.Location = new System.Drawing.Point(200, 304);
            this.LoadFormButton.Name = "LoadFormButton";
            this.LoadFormButton.Size = new System.Drawing.Size(74, 41);
            this.LoadFormButton.TabIndex = 1;
            this.LoadFormButton.Text = "Load Form ";
            this.LoadFormButton.UseVisualStyleBackColor = true;
            this.LoadFormButton.Click += new System.EventHandler(this.LoadFormButton_Click_1);
            // 
            // MemberConversionGrid
            // 
            this.MemberConversionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberConversionGrid.Location = new System.Drawing.Point(12, 66);
            this.MemberConversionGrid.Name = "MemberConversionGrid";
            this.MemberConversionGrid.Size = new System.Drawing.Size(506, 216);
            this.MemberConversionGrid.TabIndex = 2;
            // 
            // OpenFormButton
            // 
            this.OpenFormButton.Location = new System.Drawing.Point(24, 304);
            this.OpenFormButton.Name = "OpenFormButton";
            this.OpenFormButton.Size = new System.Drawing.Size(75, 41);
            this.OpenFormButton.TabIndex = 3;
            this.OpenFormButton.Text = "Open";
            this.OpenFormButton.UseVisualStyleBackColor = true;
            this.OpenFormButton.Click += new System.EventHandler(this.LoadFormButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(405, 304);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert ";
            this.ConvertButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLabel.Location = new System.Drawing.Point(12, 21);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(468, 23);
            this.OutputLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 357);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OpenFormButton);
            this.Controls.Add(this.MemberConversionGrid);
            this.Controls.Add(this.LoadFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MemberConversionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoadFormButton;
        private System.Windows.Forms.DataGridView MemberConversionGrid;
        private System.Windows.Forms.Button OpenFormButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

