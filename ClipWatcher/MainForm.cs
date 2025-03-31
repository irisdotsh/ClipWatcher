using System.Collections.Specialized;
using ClipWatcher;
using Discord.Webhook;

namespace ClipUploader
{
    public partial class MainForm : Form
    {
        public Configuration Configuration;

        private readonly ConfigurationFile _configurationFile;

        public MainForm()
        {
            InitializeComponent();

            _configurationFile = new ConfigurationFile();
            Configuration = _configurationFile.Configuration;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string? folder = Configuration.Folder;
            string? webhook = Configuration.Webhook;
            string? filter = Configuration.Filter;
            bool copy = Configuration.Copy;
            bool upload = Configuration.Upload;

            if (!String.IsNullOrEmpty(folder))
            {
                ClipsFolderTextBox.Text = folder;
                ClipsFileSystemWatcher.Path = folder;
            }

            if (!String.IsNullOrEmpty(webhook)) DiscordWebhookTextBox.Text = webhook;

            if (!String.IsNullOrEmpty(filter))
            {
                FilterTextBox.Text = filter;
                ClipsFileSystemWatcher.Filter = filter;
            }

            if (copy) CopyLatestClipCheckbox.Checked = true;
            if (upload) UploadLatestClipToDiscordCheckbox.Checked = true;
        }

        private void OpenClipsFolderButton_Click(object sender, EventArgs e)
        {
            if (ClipsFolderBrowserDialog.ShowDialog() == DialogResult.OK &&
               (ClipsFileSystemWatcher.Path != ClipsFolderBrowserDialog.SelectedPath))
            {
                ClipsFileSystemWatcher.Path = ClipsFolderBrowserDialog.SelectedPath;
                ClipsFolderTextBox.Text = ClipsFolderBrowserDialog.SelectedPath;
                Configuration.Folder = ClipsFolderBrowserDialog.SelectedPath;

                _configurationFile.Save(Configuration);
                StatusListView.Items.Clear();
            }
        }

        private void DiscordWebhookTextBox_TextChanged(object sender, EventArgs e)
        {
            Configuration.Webhook = DiscordWebhookTextBox.Text;

            _configurationFile.Save(Configuration);
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            ClipsFileSystemWatcher.Filter = FilterTextBox.Text;
            Configuration.Filter = FilterTextBox.Text;

            _configurationFile.Save(Configuration);
        }

        private void CopyLatestClipCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Copy = CopyLatestClipCheckbox.Checked;

            _configurationFile.Save(Configuration);
        }

        private void UploadLatestClipToDiscordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Upload = UploadLatestClipToDiscordCheckbox.Checked;

            _configurationFile.Save(Configuration);
        }

        private async void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (Configuration.Copy)
            {
                StringCollection files = new();

                files.Add(e.FullPath);

                try
                {
                    Clipboard.SetFileDropList(files);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to copy clip to clipboard", "Error");
                }
            }

            if (Configuration.Upload)
            {
                try
                {
                    DiscordWebhookClient hook = new(DiscordWebhookTextBox.Text);

                    await hook.SendFileAsync(e.FullPath, e.Name, false, null, "Clip Watcher");
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to upload clip to Discord", "Error");
                }
            }

            ListViewItem item = new ListViewItem(new[] { e.FullPath, Configuration.Copy.ToString(), Configuration.Upload.ToString() });
            StatusListView.Items.Add(item);
        }
    }
}
