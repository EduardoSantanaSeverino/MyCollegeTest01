using System.ComponentModel.DataAnnotations;

namespace MyCollege.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}