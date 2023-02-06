using System.ComponentModel.DataAnnotations;

namespace DT191G_moment2.Models {

    public class CourseModel {

        [Required(ErrorMessage = "Ange kursnamn")]
        [Display(Name = "Kursnamn")]
        public string? Name {get; set;}

        [Required(ErrorMessage = "Ange högskolepoäng")]
        [Display(Name = "Poäng")]
        public decimal? Points {get; set;}

        [Required(ErrorMessage = "Skriv en beskrivning av kursen")]
        [Display(Name = "Beskrivning av kurs")]
       
        public string? Description {get; set;}

        [Display(Name = "Länk till publicerat kursprojekt")]
        [Url]
        public string? PublishedURL {get; set;}

        [Display(Name = "Länk till videopresentation")]
        [Url]
        public string? VideoPresentation {get; set;}
    }
    
}