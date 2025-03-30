namespace ClipUploader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ClipsFileSystemWatcher = new FileSystemWatcher();
            ClipsFolderBrowserDialog = new FolderBrowserDialog();
            SettingsGroupBox = new GroupBox();
            FilterTextBox = new TextBox();
            FilterLabel = new Label();
            UploadLatestClipToDiscordCheckbox = new CheckBox();
            CopyLatestClipCheckbox = new CheckBox();
            DiscordWebhookTextBox = new TextBox();
            DiscordWebhookLabel = new Label();
            OpenClipsFolderButton = new Button();
            ClipsFolderTextBox = new TextBox();
            ClipsFolderLabel = new Label();
            StatusListView = new ListView();
            ClipPathHeader = new ColumnHeader();
            CopiedHeader = new ColumnHeader();
            UploadedHeader = new ColumnHeader();
            StatusGroupBox = new GroupBox();
            ErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ClipsFileSystemWatcher).BeginInit();
            SettingsGroupBox.SuspendLayout();
            StatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // ClipsFileSystemWatcher
            // 
            ClipsFileSystemWatcher.EnableRaisingEvents = true;
            ClipsFileSystemWatcher.Filter = "*.mp4";
            ClipsFileSystemWatcher.IncludeSubdirectories = true;
            ClipsFileSystemWatcher.SynchronizingObject = this;
            ClipsFileSystemWatcher.Created += OnCreated;
            // 
            // SettingsGroupBox
            // 
            SettingsGroupBox.Controls.Add(FilterTextBox);
            SettingsGroupBox.Controls.Add(FilterLabel);
            SettingsGroupBox.Controls.Add(UploadLatestClipToDiscordCheckbox);
            SettingsGroupBox.Controls.Add(CopyLatestClipCheckbox);
            SettingsGroupBox.Controls.Add(DiscordWebhookTextBox);
            SettingsGroupBox.Controls.Add(DiscordWebhookLabel);
            SettingsGroupBox.Controls.Add(OpenClipsFolderButton);
            SettingsGroupBox.Controls.Add(ClipsFolderTextBox);
            SettingsGroupBox.Controls.Add(ClipsFolderLabel);
            SettingsGroupBox.Location = new Point(12, 12);
            SettingsGroupBox.Name = "SettingsGroupBox";
            SettingsGroupBox.Size = new Size(529, 104);
            SettingsGroupBox.TabIndex = 0;
            SettingsGroupBox.TabStop = false;
            SettingsGroupBox.Text = "Settings";
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(119, 74);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(71, 23);
            FilterTextBox.TabIndex = 8;
            FilterTextBox.TextChanged += FilterTextBox_TextChanged;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Location = new Point(6, 74);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(39, 15);
            FilterLabel.TabIndex = 7;
            FilterLabel.Text = "Filter: ";
            // 
            // UploadLatestClipToDiscordCheckbox
            // 
            UploadLatestClipToDiscordCheckbox.AutoSize = true;
            UploadLatestClipToDiscordCheckbox.Location = new Point(317, 76);
            UploadLatestClipToDiscordCheckbox.Name = "UploadLatestClipToDiscordCheckbox";
            UploadLatestClipToDiscordCheckbox.Size = new Size(179, 19);
            UploadLatestClipToDiscordCheckbox.TabIndex = 6;
            UploadLatestClipToDiscordCheckbox.Text = "Upload Latest Clip to Discord";
            UploadLatestClipToDiscordCheckbox.UseVisualStyleBackColor = true;
            // 
            // CopyLatestClipCheckbox
            // 
            CopyLatestClipCheckbox.AutoSize = true;
            CopyLatestClipCheckbox.Location = new Point(199, 76);
            CopyLatestClipCheckbox.Name = "CopyLatestClipCheckbox";
            CopyLatestClipCheckbox.Size = new Size(112, 19);
            CopyLatestClipCheckbox.TabIndex = 5;
            CopyLatestClipCheckbox.Text = "Copy Latest Clip";
            CopyLatestClipCheckbox.UseVisualStyleBackColor = true;
            // 
            // DiscordWebhookTextBox
            // 
            DiscordWebhookTextBox.Location = new Point(119, 45);
            DiscordWebhookTextBox.Name = "DiscordWebhookTextBox";
            DiscordWebhookTextBox.Size = new Size(377, 23);
            DiscordWebhookTextBox.TabIndex = 4;
            DiscordWebhookTextBox.Validating += DiscordWebhookTextBox_Validating;
            // 
            // DiscordWebhookLabel
            // 
            DiscordWebhookLabel.AutoSize = true;
            DiscordWebhookLabel.Location = new Point(6, 48);
            DiscordWebhookLabel.Name = "DiscordWebhookLabel";
            DiscordWebhookLabel.Size = new Size(107, 15);
            DiscordWebhookLabel.TabIndex = 3;
            DiscordWebhookLabel.Text = "Discord Webhook: ";
            // 
            // OpenClipsFolderButton
            // 
            OpenClipsFolderButton.Location = new Point(421, 16);
            OpenClipsFolderButton.Name = "OpenClipsFolderButton";
            OpenClipsFolderButton.Size = new Size(75, 23);
            OpenClipsFolderButton.TabIndex = 2;
            OpenClipsFolderButton.Text = "Browse";
            OpenClipsFolderButton.UseVisualStyleBackColor = true;
            OpenClipsFolderButton.Click += OpenClipsFolderButton_Click;
            // 
            // ClipsFolderTextBox
            // 
            ClipsFolderTextBox.Location = new Point(119, 16);
            ClipsFolderTextBox.Name = "ClipsFolderTextBox";
            ClipsFolderTextBox.ReadOnly = true;
            ClipsFolderTextBox.Size = new Size(296, 23);
            ClipsFolderTextBox.TabIndex = 1;
            // 
            // ClipsFolderLabel
            // 
            ClipsFolderLabel.AutoSize = true;
            ClipsFolderLabel.Location = new Point(6, 20);
            ClipsFolderLabel.Name = "ClipsFolderLabel";
            ClipsFolderLabel.Size = new Size(75, 15);
            ClipsFolderLabel.TabIndex = 0;
            ClipsFolderLabel.Text = "Clips Folder: ";
            // 
            // StatusListView
            // 
            StatusListView.Columns.AddRange(new ColumnHeader[] { ClipPathHeader, CopiedHeader, UploadedHeader });
            StatusListView.Location = new Point(6, 22);
            StatusListView.Name = "StatusListView";
            StatusListView.Size = new Size(514, 124);
            StatusListView.TabIndex = 1;
            StatusListView.UseCompatibleStateImageBehavior = false;
            StatusListView.View = View.Details;
            // 
            // ClipPathHeader
            // 
            ClipPathHeader.Text = "Clip";
            ClipPathHeader.Width = 226;
            // 
            // CopiedHeader
            // 
            CopiedHeader.Text = "Copied to Clipboard";
            CopiedHeader.Width = 142;
            // 
            // UploadedHeader
            // 
            UploadedHeader.Text = "Uploaded to Discord";
            UploadedHeader.Width = 142;
            // 
            // StatusGroupBox
            // 
            StatusGroupBox.Controls.Add(StatusListView);
            StatusGroupBox.Location = new Point(12, 122);
            StatusGroupBox.Name = "StatusGroupBox";
            StatusGroupBox.Size = new Size(529, 152);
            StatusGroupBox.TabIndex = 2;
            StatusGroupBox.TabStop = false;
            StatusGroupBox.Text = "Status";
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 281);
            Controls.Add(StatusGroupBox);
            Controls.Add(SettingsGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Clip Watcher";
            ((System.ComponentModel.ISupportInitialize)ClipsFileSystemWatcher).EndInit();
            SettingsGroupBox.ResumeLayout(false);
            SettingsGroupBox.PerformLayout();
            StatusGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher ClipsFileSystemWatcher;
        private GroupBox SettingsGroupBox;
        private Button OpenClipsFolderButton;
        private TextBox ClipsFolderTextBox;
        private Label ClipsFolderLabel;
        private FolderBrowserDialog ClipsFolderBrowserDialog;
        private CheckBox CopyLatestClipCheckbox;
        private TextBox DiscordWebhookTextBox;
        private Label DiscordWebhookLabel;
        private CheckBox UploadLatestClipToDiscordCheckbox;
        private GroupBox StatusGroupBox;
        private ListView StatusListView;
        private ColumnHeader ClipPathHeader;
        private ColumnHeader CopiedHeader;
        private ColumnHeader UploadedHeader;
        private TextBox FilterTextBox;
        private Label FilterLabel;
        private ErrorProvider ErrorProvider;
    }
}
