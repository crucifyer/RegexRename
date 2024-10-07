namespace RegexRename
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtFolderPath = new TextBox();
            btnBrowse = new Button();
            txtRegexPattern = new TextBox();
            txtReplacement = new TextBox();
            btnRename = new Button();
            lvFiles = new ListView();
            columnFileName = new ColumnHeader();
            columnNewFileName = new ColumnHeader();
            panelFolderPath = new Panel();
            panelRegexPattern = new Panel();
            panelReplacement = new Panel();
            panelLvFiles = new Panel();
            panelFolderPath.SuspendLayout();
            panelRegexPattern.SuspendLayout();
            panelReplacement.SuspendLayout();
            panelLvFiles.SuspendLayout();
            SuspendLayout();
            // 
            // txtFolderPath
            // 
            txtFolderPath.Dock = DockStyle.Fill;
            txtFolderPath.Location = new Point(0, 0);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.PlaceholderText = "Folder Path";
            txtFolderPath.Size = new Size(719, 23);
            txtFolderPath.TabIndex = 0;
            txtFolderPath.TextChanged += TxtFolderPath_TextChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Right;
            btnBrowse.Location = new Point(719, 0);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browser";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // txtRegexPattern
            // 
            txtRegexPattern.Dock = DockStyle.Top;
            txtRegexPattern.Location = new Point(0, 3);
            txtRegexPattern.Name = "txtRegexPattern";
            txtRegexPattern.PlaceholderText = "Regular Expression Pattern";
            txtRegexPattern.Size = new Size(794, 23);
            txtRegexPattern.TabIndex = 0;
            txtRegexPattern.TextChanged += TxtRegexPattern_TextChanged;
            // 
            // txtReplacement
            // 
            txtReplacement.Dock = DockStyle.Fill;
            txtReplacement.Location = new Point(0, 3);
            txtReplacement.Name = "txtReplacement";
            txtReplacement.PlaceholderText = "Replacement Text";
            txtReplacement.Size = new Size(719, 23);
            txtReplacement.TabIndex = 0;
            txtReplacement.TextChanged += TxtReplacement_TextChanged;
            // 
            // btnRename
            // 
            btnRename.Dock = DockStyle.Right;
            btnRename.Location = new Point(719, 3);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(75, 23);
            btnRename.TabIndex = 1;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += BtnRename_Click;
            // 
            // lvFiles
            // 
            lvFiles.Columns.AddRange(new ColumnHeader[] { columnFileName, columnNewFileName });
            lvFiles.Dock = DockStyle.Fill;
            lvFiles.Location = new Point(0, 3);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(794, 366);
            lvFiles.TabIndex = 0;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.Details;
            // 
            // columnFileName
            // 
            columnFileName.Text = "File Name";
            columnFileName.Width = 388;
            // 
            // columnNewFileName
            // 
            columnNewFileName.Text = "New File Name";
            columnNewFileName.Width = 388;
            // 
            // panelFolderPath
            // 
            panelFolderPath.Controls.Add(txtFolderPath);
            panelFolderPath.Controls.Add(btnBrowse);
            panelFolderPath.Dock = DockStyle.Top;
            panelFolderPath.Location = new Point(3, 3);
            panelFolderPath.Name = "panelFolderPath";
            panelFolderPath.Size = new Size(794, 23);
            panelFolderPath.TabIndex = 1;
            // 
            // panelRegexPattern
            // 
            panelRegexPattern.Controls.Add(txtRegexPattern);
            panelRegexPattern.Dock = DockStyle.Top;
            panelRegexPattern.Location = new Point(3, 26);
            panelRegexPattern.Name = "panelRegexPattern";
            panelRegexPattern.Padding = new Padding(0, 3, 0, 0);
            panelRegexPattern.Size = new Size(794, 26);
            panelRegexPattern.TabIndex = 2;
            // 
            // panelReplacement
            // 
            panelReplacement.Controls.Add(txtReplacement);
            panelReplacement.Controls.Add(btnRename);
            panelReplacement.Dock = DockStyle.Top;
            panelReplacement.Location = new Point(3, 52);
            panelReplacement.Name = "panelReplacement";
            panelReplacement.Padding = new Padding(0, 3, 0, 0);
            panelReplacement.Size = new Size(794, 26);
            panelReplacement.TabIndex = 3;
            // 
            // panelLvFiles
            // 
            panelLvFiles.Controls.Add(lvFiles);
            panelLvFiles.Dock = DockStyle.Fill;
            panelLvFiles.Location = new Point(3, 78);
            panelLvFiles.Name = "panelLvFiles";
            panelLvFiles.Padding = new Padding(0, 3, 0, 0);
            panelLvFiles.Size = new Size(794, 369);
            panelLvFiles.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLvFiles);
            Controls.Add(panelReplacement);
            Controls.Add(panelRegexPattern);
            Controls.Add(panelFolderPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Padding = new Padding(3);
            Text = "RegexRename     - Icons by https://icons8.com -";
            Resize += MainForm_Resize;
            panelFolderPath.ResumeLayout(false);
            panelFolderPath.PerformLayout();
            panelRegexPattern.ResumeLayout(false);
            panelRegexPattern.PerformLayout();
            panelReplacement.ResumeLayout(false);
            panelReplacement.PerformLayout();
            panelLvFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFolderPath;
        private Button btnBrowse;
        private TextBox txtRegexPattern;
        private TextBox txtReplacement;
        private Button btnRename;
        private ListView lvFiles;
        private ColumnHeader columnFileName;
        private ColumnHeader columnNewFileName;
        private Panel panelFolderPath;
        private Panel panelRegexPattern;
        private Panel panelReplacement;
        private Panel panelLvFiles;
    }
}