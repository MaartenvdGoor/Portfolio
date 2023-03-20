using System.Text.Json;

namespace ASP_Portfolio.Models
{
	public class Project
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string[][]? Info_Image { get; set; }

		public string? Main_Image { get; set; }

		public string[]? Technology_Used { get; set; }

		public string Tech_Image { get; set; }

		public string Git_Link { get; set; }

		public override string ToString() => JsonSerializer.Serialize<Project>(this);

	}
}
