using System.ComponentModel.DataAnnotations;

namespace DT191G_moment2.Models {

    public class LoginModel {

        [Required(ErrorMessage = "Ange användarnamn")]
        [Display(Name = "Användarnamn")]
        public string? Username {get; set;}

        [Required(ErrorMessage = "Ange lösenord")]
        [Display(Name = "Lösenord")]
        public string? Password {get; set;}

        
    }
    
}