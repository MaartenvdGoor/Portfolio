using ASP_Portfolio.Models;
using System.Collections;
using System.Text.Json;

namespace ASP_Portfolio.Services
{
	public class JsonFileProjectService
	{
		public JsonFileProjectService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		public IWebHostEnvironment WebHostEnvironment { get; }

		private string JsonFileName {
			get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Projects.json"); }
		}

		public IEnumerable<Project>? GetProducts()
		{
			using (var jsonFileReader = File.OpenText(JsonFileName))
			{
				return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
					new JsonSerializerOptions
					{
						PropertyNameCaseInsensitive = true
					});
			}
			
		}
	} 
}
