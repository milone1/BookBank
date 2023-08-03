using System;
namespace Nueva_app.Models
{
	public class BarSettings : IBarSettings
	{
        public string Server { get; set; } = null!;
        public string Database { get; set; } = null!;
        public string Collection { get; set; } = null!;
    }

    public interface IBarSettings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}

