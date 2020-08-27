using System.ComponentModel.DataAnnotations;

namespace ClothingShope.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}