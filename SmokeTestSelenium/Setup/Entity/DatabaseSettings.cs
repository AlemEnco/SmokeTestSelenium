namespace SmokeTestSelenium.Setup.Entity
{
    public class DatabaseSettings
    {
        public Database Database { get; set; }
    }

    public class Database
    {
        public String Host { get; set; }
        public String Data { get; set; }
        public String User { get; set; }
        public String Pass { get; set; }
    }
}
