using Microsoft.AspNetCore.Mvc;
using SampleProject.Abstraction.Data;

namespace SampleProject.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(ISampleProjectData data)
        {
            this.Data = data;
        }

        public ISampleProjectData Data { get; set; }
    }
}