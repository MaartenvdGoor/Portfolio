using ASP_Portfolio.Models;
using ASP_Portfolio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_Portfolio.Pages
{
    public class ProjectModel : PageModel
    {
        public string Title { get; set; }
        public Project project;
		public JsonFileProjectService ProjectService;

        public ProjectModel(JsonFileProjectService projectService) => ProjectService = projectService;

        public void OnGet(string title)
        {
            project = ProjectService.GetProject(title);
        }
    }
}
