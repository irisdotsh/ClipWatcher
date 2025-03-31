using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ClipWatcher
{
    public class ConfigurationFile
    {
        public Configuration Configuration
        {
            get
            {
                IDeserializer deserializer = new DeserializerBuilder()
                    .WithNamingConvention(UnderscoredNamingConvention.Instance)
                    .Build();

                Configuration configuration = deserializer.Deserialize<Configuration>(Read());

                return configuration;
            }
        }

        private string DirectoryPath
        {
            get
            {
                return Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "irisdotsh",
                    "clipwatcher"
                );
            }
        }

        private string FilePath
        {
            get => Path.Combine(DirectoryPath, "config.yml");
        }

        private const string DefaultConfiguration = "folder: null\nwebhook: null\nfilter: \"*.mp4\"\ncopy: false\nupload: false";

        public ConfigurationFile()
        {
            Directory.CreateDirectory(DirectoryPath);

            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, DefaultConfiguration);
            }
        }

        public void Save(Configuration configuration)
        {
            ISerializer serializer = new SerializerBuilder()
                .WithNamingConvention(UnderscoredNamingConvention.Instance)
                .Build();

            string content = serializer.Serialize(configuration);

            Write(content);
        }

        private string Read() => File.ReadAllText(FilePath);

        private void Write(string content) => File.WriteAllText(FilePath, content);
    }
}
