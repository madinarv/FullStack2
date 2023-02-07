using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace Eterna.Models
{
    public class Teams
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string TeacherName { get; set; }

        [Required, StringLength(255)]
        public string TeacherBranch { get; set; }
        [Required, StringLength(255)]
        public string TeacherDescription { get;set; }
        [Required, StringLength(255)]
        public string? TeacherImage { get; set;}
    }
}
