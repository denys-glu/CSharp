using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModel.Models 
{
    public class Survey {
        [Required]
        [MinLength(2, ErrorMessage="At least two characters long")]
        public string Name {get; set;}
        [Required]
        public string Location {get; set;}
        [Required]
        public string FavLanguage {get; set;}
        [MinLength(20, ErrorMessage="At least 20 charachters long")]
        public string Comment {get; set;}
    }
}