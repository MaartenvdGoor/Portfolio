using ASP_Portfolio.Models;
using ASP_Portfolio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_Portfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public JsonFileProjectService ProjectService;
        public IEnumerable<Project>? Projects { get; private set; }

		public ProjectsModel(JsonFileProjectService projectService) => ProjectService = projectService;


		public void OnGet()
        {
            Projects = ProjectService.GetProjects();
        }
    }
}
