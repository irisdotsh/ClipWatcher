namespace ClipWatcher
{
    public class Configuration
    {
        public required string? Folder;
        public required string? Webhook;
        public required string? Filter;
        public required bool Copy;
        public required bool Upload;
    }
}
