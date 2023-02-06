using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DT191G_moment2.Models;

namespace DT191G_Moment2.Controllers {

    public class HomeController : Controller {

        //Home Page - return view only
        public IActionResult Index(){
            return View();
        }
        
        //Display projects - load daata from json-file and send data to view
        [Route("/projects")]
        public IActionResult Projects(){
            
            var JsonStr = System.IO.File.ReadAllText("projects.json");
            var JsonObj = JsonConvert.DeserializeObject<List<ProjectModel>>(JsonStr);

            return View(JsonObj);
        }

        //Display courses - load daata from json-file and send data to view
        [Route("/courses")]
        public IActionResult Courses(){

            var JsonStr = System.IO.File.ReadAllText("courses.json");
            var JsonObj = JsonConvert.DeserializeObject<List<CourseModel>>(JsonStr);

            return View(JsonObj);
        }

        //CV - return view only
        [Route("/cv")]
        public IActionResult CV(){
            return View();
        }

        

    }
}