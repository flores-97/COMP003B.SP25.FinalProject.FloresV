using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace COMP003B.SP25.FinalProject.FloresV.Models
{
    public class Rank
    {
        public int RankId { get; set; }
        [Required]
        public string Title { get; set; }
        public virtual ICollection<Branch>? Branches { get; set; }

    }
}
