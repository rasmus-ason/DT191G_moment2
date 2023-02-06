using DT191G_moment2.Models;

using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;




namespace DT191G_Moment2.Controllers {

    public class LoginController : Controller {


        //Login
        [Route("/login")]
        public IActionResult Login(){
            return View();
        }

        //Logout - destroy cookie and return to home/index
        [Route("/logout")]
        public IActionResult Logout(){

            HttpContext.Response.Cookies.Delete("Username");

            return RedirectToAction("Index", "Home");
        }

        //Http request post - log in user
        [HttpPost("/login")]
        public IActionResult Login(LoginModel model){

            //Check values of the body
            if (model.Username == "admin" && model.Password == "password")
            {
                // Set the data in a cookie
                HttpContext.Response.Cookies.Append("Username", "Username=" + model.Username, 
                new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(1)
                });

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.InvalidCredentials = "Incorrect username or password";
                return View();
            }

        }

        
    }
}