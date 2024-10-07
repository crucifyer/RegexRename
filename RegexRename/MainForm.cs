using System.Text.RegularExpressions;

namespace RegexRename
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TxtFolderPath_TextChanged(object sender, EventArgs e)
        {
            UpdateFileList();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = fbd.SelectedPath;
            }
        }

        private void TxtRegexPattern_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRegexPattern.Text))
                {
                    Regex.Match("", txtRegexPattern.Text);
                    txtRegexPattern.BackColor = SystemColors.Window;
                }
                UpdateFileList();
            }
            catch (ArgumentException)
            {
                txtRegexPattern.BackColor = Color.LightPink;
            }
        }

        private void TxtReplacement_TextChanged(object sender, EventArgs e)
        {
            UpdateFileList();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            PerformRename();
        }

        private void UpdateFileList()
        {
            lvFiles.Items.Clear();
            btnRename.Enabled = false;
            if (!Directory.Exists(txtFolderPath.Text))
            {
                txtFolderPath.BackColor = Color.LightPink;
                return;
            }
            txtFolderPath.BackColor = SystemColors.Window;

            var files = Directory.GetFiles(txtFolderPath.Text);
            var regex = string.IsNullOrEmpty(txtRegexPattern.Text) ? null : new Regex(txtRegexPattern.Text);
            var newNames = new Dictionary<string, int>();
            bool hasWarnings = false;

            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var match = regex?.Match(fileName);
                if (regex == null || match?.Success == true)
                {
                    var newName = regex == null ? fileName : regex.Replace(fileName, txtReplacement.Text);
                    if (fileName == newName) continue;
                    var item = lvFiles.Items.Add(fileName);
                    item.SubItems.Add(newName);

                    if (newNames.ContainsKey(newName))
                    {
                        newNames[newName]++;
                        item.BackColor = Color.LightYellow;
                        hasWarnings = true;

                        for (int i = 0; i < lvFiles.Items.Count - 1; i++)
                        {
                            if (lvFiles.Items[i].SubItems[1].Text == newName)
                            {
                                lvFiles.Items[i].BackColor = Color.LightYellow;
                            }
                        }
                    }
                    else
                    {
                        newNames[newName] = 1;
                    }

                    if (match?.Success == true)
                    {
                        item.BackColor = Color.LightGreen;
                    }
                }
            }

            if (lvFiles.Items.Count > 0 && !hasWarnings)
            {
                btnRename.Enabled = true;
            }
        }

        private void PerformRename()
        {
            foreach (ListViewItem item in lvFiles.Items)
            {
                var oldPath = Path.Combine(txtFolderPath.Text, item.Text);
                var newPath = Path.Combine(txtFolderPath.Text, item.SubItems[1].Text);
                if (oldPath != newPath)
                {
                    File.Move(oldPath, newPath);
                }
            }
            UpdateFileList();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int newWidth = (lvFiles.Width - SystemInformation.VerticalScrollBarArrowHeight) >> 1;
            lvFiles.Columns[0].Width = newWidth;
            lvFiles.Columns[1].Width = newWidth;
        }
    }
}