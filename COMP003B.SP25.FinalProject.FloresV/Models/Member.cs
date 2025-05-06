using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.FloresV.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<Branch>? Branches { get; set; }

        [Required]
        [Range(17, 70)]
        public int Age { get; set; }
    }
}
