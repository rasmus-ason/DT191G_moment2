using System.ComponentModel.DataAnnotations;

namespace DT191G_moment2.Models {

    public class ProjectModel {

        [Required(ErrorMessage = "Ange projektnamn")]
        [Display(Name = "Sätt en rubrik på projekt")]
        [MinLength(6, ErrorMessage = "Minst 6 tecken")]
        public string? ProjectName {get; set;}

        [Required(ErrorMessage = "Ange kurs")]
        [Display(Name = "Vilken kurs avsedde projektet")]
        public string? CourseName {get; set;}

        [Required(ErrorMessage = "Ange minst ett alternativ")]
        [Display(Name = "Vilka programmeringsspråk/ramverk/plattformar användes?")]
        public List<string>? Techniques {get; set;}

        [Required(ErrorMessage = "Skriv en beskrivning av projektet")]
        [Display(Name = "Beskrivning av kurs")]
        [MaxLength(1200)]
        public string? ProjectDescription {get; set;}

        [Display(Name = "Finns projektet publicerat?")]
        public bool? IsPublished {get; set;}

        [Display(Name = "Länk till publicerat projekt")]
        public string? PublishUrl {get; set;}

        [Display(Name = "Länk till videopresentation")]
        public bool? isPresentation {get; set;}

        [Display(Name = "Länk till presentation")]
        public string? PresentationUrl {get; set;}

        [Required(ErrorMessage = "Bild måste inkluderas")]
        [Display(Name = "Projektbild")]
        public string? ImagePath {get; set;}
    }
    
}