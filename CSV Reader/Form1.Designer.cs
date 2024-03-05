namespace CSV_Reader
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
            this.ImportFileButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.HeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnDropDown = new System.Windows.Forms.ComboBox();
            this.FilterOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.FileOptionsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.FilterOptionsGroupBox.SuspendLayout();
            this.FileOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportFileButton
            // 
            this.ImportFileButton.Location = new System.Drawing.Point(90, 22);
            this.ImportFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImportFileButton.Name = "ImportFileButton";
            this.ImportFileButton.Size = new System.Drawing.Size(120, 37);
            this.ImportFileButton.TabIndex = 0;
            this.ImportFileButton.Text = "Import CSV File";
            this.ImportFileButton.UseVisualStyleBackColor = true;
            this.ImportFileButton.Click += new System.EventHandler(this.ImportFileButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(16, 479);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 16);
            this.FileNameLabel.TabIndex = 2;
            // 
            // HeaderCheckBox
            // 
            this.HeaderCheckBox.AutoSize = true;
            this.HeaderCheckBox.Checked = true;
            this.HeaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeaderCheckBox.Location = new System.Drawing.Point(13, 67);
            this.HeaderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderCheckBox.Name = "HeaderCheckBox";
            this.HeaderCheckBox.Size = new System.Drawing.Size(273, 20);
            this.HeaderCheckBox.TabIndex = 3;
            this.HeaderCheckBox.Text = "Use first row values as Column Headers?";
            this.HeaderCheckBox.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(336, 13);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(541, 462);
            this.DataGridView.TabIndex = 4;
            // 
            // ColumnDropDown
            // 
            this.ColumnDropDown.FormattingEnabled = true;
            this.ColumnDropDown.Location = new System.Drawing.Point(130, 25);
            this.ColumnDropDown.Name = "ColumnDropDown";
            this.ColumnDropDown.Size = new System.Drawing.Size(156, 24);
            this.ColumnDropDown.TabIndex = 5;
            // 
            // FilterOptionsGroupBox
            // 
            this.FilterOptionsGroupBox.Controls.Add(this.ResetButton);
            this.FilterOptionsGroupBox.Controls.Add(this.ApplyButton);
            this.FilterOptionsGroupBox.Controls.Add(this.ValueLabel);
            this.FilterOptionsGroupBox.Controls.Add(this.ValueTextBox);
            this.FilterOptionsGroupBox.Controls.Add(this.ColumnLabel);
            this.FilterOptionsGroupBox.Controls.Add(this.ColumnDropDown);
            this.FilterOptionsGroupBox.Location = new System.Drawing.Point(12, 114);
            this.FilterOptionsGroupBox.Name = "FilterOptionsGroupBox";
            this.FilterOptionsGroupBox.Size = new System.Drawing.Size(317, 138);
            this.FilterOptionsGroupBox.TabIndex = 6;
            this.FilterOptionsGroupBox.TabStop = false;
            this.FilterOptionsGroupBox.Text = "Filter Options";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(37, 96);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(95, 35);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(191, 96);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(95, 35);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(34, 61);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(42, 16);
            this.ValueLabel.TabIndex = 8;
            this.ValueLabel.Text = "Value";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(130, 58);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(156, 22);
            this.ValueTextBox.TabIndex = 7;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(34, 28);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(52, 16);
            this.ColumnLabel.TabIndex = 6;
            this.ColumnLabel.Text = "Column";
            // 
            // FileOptionsGroupBox
            // 
            this.FileOptionsGroupBox.Controls.Add(this.ImportFileButton);
            this.FileOptionsGroupBox.Controls.Add(this.HeaderCheckBox);
            this.FileOptionsGroupBox.Location = new System.Drawing.Point(12, 13);
            this.FileOptionsGroupBox.Name = "FileOptionsGroupBox";
            this.FileOptionsGroupBox.Size = new System.Drawing.Size(317, 95);
            this.FileOptionsGroupBox.TabIndex = 7;
            this.FileOptionsGroupBox.TabStop = false;
            this.FileOptionsGroupBox.Text = "File Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 506);
            this.Controls.Add(this.FileOptionsGroupBox);
            this.Controls.Add(this.FilterOptionsGroupBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.FileNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.FilterOptionsGroupBox.ResumeLayout(false);
            this.FilterOptionsGroupBox.PerformLayout();
            this.FileOptionsGroupBox.ResumeLayout(false);
            this.FileOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportFileButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.CheckBox HeaderCheckBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ComboBox ColumnDropDown;
        private System.Windows.Forms.GroupBox FilterOptionsGroupBox;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox FileOptionsGroupBox;
    }
}

