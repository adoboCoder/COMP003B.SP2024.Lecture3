// TODO: add data annotations library
using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP2024.Lecture3.Models
{
    public class Student
    {
        // TODO: other c# built-in data types https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
        // TODO: data in square brackets are data annotations
        [Required]
        // TODO: below is an example of a property
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Required]
        [Range(0,120)]
        public int Age { get; set; }

    }
}
