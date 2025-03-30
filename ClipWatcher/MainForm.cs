using System.Collections.Specialized;
using System.ComponentModel;
using Discord.Webhook;

namespace ClipUploader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenClipsFolderButton_Click(object sender, EventArgs e)
        {
            if (ClipsFolderBrowserDialog.ShowDialog() == DialogResult.OK &&
               (ClipsFileSystemWatcher.Path != ClipsFolderBrowserDialog.SelectedPath))
            {
                ClipsFileSystemWatcher.Path = ClipsFolderBrowserDialog.SelectedPath;
                ClipsFolderTextBox.Text = ClipsFolderBrowserDialog.SelectedPath;
                StatusListView.Items.Clear();
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            ClipsFileSystemWatcher.Filter = FilterTextBox.Text;
        }

        private async void OnCreated(object sender, FileSystemEventArgs e)
        {
            bool copy = CopyLatestClipCheckbox.Checked;
            bool upload = UploadLatestClipToDiscordCheckbox.Checked;

            if (copy)
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

            if (upload)
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

            ListViewItem item = new ListViewItem(new[] { e.FullPath, copy.ToString(), upload.ToString() });
            StatusListView.Items.Add(item);
        }
    }
}
