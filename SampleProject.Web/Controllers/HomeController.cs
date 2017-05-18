using Microsoft.AspNetCore.Mvc;
using SampleProject.Abstraction.Data;
using SampleProject.Abstraction.Models;
using SampleProject.Abstraction.Services;

namespace SampleProject.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IHomeService HomeService { get; set; }

        public HomeController(ISampleProjectData data, IHomeService homeService)
            : base(data)
        {
            this.HomeService = homeService;
        }

        public IActionResult Index()
        {
            IHomeModel model = this.HomeService.GetModel();

            // Test only.
            this.Data.TestEFEntitiesRepository.Add(new Entities.TestEFEntity() { Name = "test", Value = "update2" });
            this.Data.TestEFEntitiesRepository.Save();

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
