using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    //Same as create, might need to change something in the future (thats why)
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}