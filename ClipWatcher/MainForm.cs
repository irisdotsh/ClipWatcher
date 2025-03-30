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
            if (ClipsFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ClipsFileSystemWatcher.Path = ClipsFolderBrowserDialog.SelectedPath;
                ClipsFolderTextBox.Text = ClipsFolderBrowserDialog.SelectedPath;
                StatusListView.Items.Clear();
            }
        }

        private void DiscordWebhookTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(DiscordWebhookTextBox.Text))
            {
                if (!DiscordWebhookTextBox.Text.StartsWith("https://discord.com/api/webhooks/"))
                {
                    DiscordWebhookTextBoxErrorProvider.SetError(DiscordWebhookTextBox, "Please enter a valid Discord webhook.");
                }
                else
                {
                    DiscordWebhookTextBoxErrorProvider.Clear();
                }
            }
            else
            {
                DiscordWebhookTextBoxErrorProvider.Clear();
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            ClipsFileSystemWatcher.Filter = FilterTextBox.Text;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            bool copy = CopyLatestClipCheckbox.Checked;
            bool upload = UploadLatestClipToDiscordCheckbox.Checked;

            if (copy)
            {
                StringCollection files = new StringCollection();

                files.Add(e.FullPath);

                try
                {
                    Clipboard.SetFileDropList(files);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Message: {ex.Message}\nStacktrace: {ex.StackTrace}\nSource: {ex.Source}", "Error");
                }
            }

            if (upload)
            {
                try
                {
                    DiscordWebhookClient hook = new DiscordWebhookClient(DiscordWebhookTextBox.Text);

                    hook.SendFileAsync(e.FullPath, e.Name, false, null, "Clip Watcher");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Message: {ex.Message}\nStacktrace: {ex.StackTrace}\nSource: {ex.Source}", "Error");
                }
            }

            ListViewItem item = new ListViewItem(new[] { e.FullPath, copy.ToString(), upload.ToString() });
            StatusListView.Items.Add(item);

        }
    }
}
