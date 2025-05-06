using COMP003B.SP25.FinalProject.FloresV.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.FloresV.Data
{
    public class WebDevAcademyContext :DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options) { } 

        public DbSet<Member> Members { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Branch> Branches { get; set; }

    }
}
