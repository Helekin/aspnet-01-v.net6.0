using _01_portfolio.Models;

namespace _01_portfolio.Services
{
    public interface IProjectsService
    {
        List<ProjectViewModel> GetProjects();
    }

    public class ProjectsService : IProjectsService
    {
        public List<ProjectViewModel> GetProjects()
        {
            return new List<ProjectViewModel>()
            {
                new ProjectViewModel
                {
                    Title = "Continental School",
                    Description = "Web Page",
                    Link = "https://continentaltiamarita.com",
                    ImageUrl = "/img/continental-school-website.png"
                },
                new ProjectViewModel
                {
                    Title = "Sonibel",
                    Description = "E-commerce Web Page",
                    Link = "https://sonibelec.com/",
                    ImageUrl = "/img/sonibel-website.png"
                }
            };
        }
    }
}
