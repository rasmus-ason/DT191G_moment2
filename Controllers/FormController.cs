using DT191G_moment2.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;






namespace DT191G_Moment2.Controllers {


    //Add Project to JSON file
    public class FormController : Controller {
        
        [Route("/add-project")]
        public IActionResult AddProject(){

            // Get the data from the cookie - check if user is logged inv
            string? cookieValue = HttpContext.Request.Cookies["Username"]?.Split("=")[1];
            if (cookieValue != "admin")
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }

        }

        //Add course to JSON file
        [Route("/add-course")]
        public IActionResult AddCourse(){

            // Get the data from the cookie - check if user is logged in
            string? cookieValue = HttpContext.Request.Cookies["Username"]?.Split("=")[1];
            if (cookieValue != "admin")
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }

        //HTTP post request - add course
        [HttpPost("/add-course")]
        public IActionResult AddCourse(CourseModel model){

            //Check validity of model
            if(ModelState.IsValid){
                //Convert and store
                var JsonStr = System.IO.File.ReadAllText("courses.json");
                var JsonObj = JsonConvert.DeserializeObject<List<CourseModel>>(JsonStr);

                if(JsonObj != null) {
                    JsonObj.Add(model);
                    //Formatting Intended är för läsbarheten i json-filen
                    System.IO.File.WriteAllText("courses.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                    //Add user message
                    ViewBag.AddedCourseSuccess = "Kurs inlagd!";

                    //Clear form
                    ModelState.Clear();
                }

            }

            return View();
        }

        //HTTP request post - add project
        [HttpPost("/add-project")]
        public IActionResult AddProject(ProjectModel model){

            if(ModelState.IsValid){
                //Konvertera och lagra enligt model
                var JsonStr = System.IO.File.ReadAllText("projects.json");
                var JsonObj = JsonConvert.DeserializeObject<List<ProjectModel>>(JsonStr);

                if(JsonObj != null) {
                    JsonObj.Add(model);
                    //Formatting Intended är för läsbarheten i json-filen
                    System.IO.File.WriteAllText("projects.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                    ViewBag.AddedProjectSuccess = "Projekt inlagt!";

                    ModelState.Clear();
                }

            }

            return View();
        }
    }
}