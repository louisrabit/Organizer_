using System.ComponentModel.DataAnnotations;

namespace OrganizMyLife.Classes
{
    public class Task_Classes
    {
        [Required(ErrorMessage ="Title is Required")]
        [MinLength(2, ErrorMessage = "Title must be at least of length 2 ")]
        public string Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "Description is Required")]
        [MinLength(5, ErrorMessage = "Description must be at least of length 5 ")]
        [MaxLength(70, ErrorMessage = "Max 70 characters allowed!")]
        public string Task_Body { get; set; } = string.Empty;

        [Required(ErrorMessage = "Priority is Required")]
        public string Priority { get; set; } = string.Empty;
        

        public int Id { get; set; } = 0;

    }
}
