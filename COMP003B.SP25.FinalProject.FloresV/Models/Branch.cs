namespace COMP003B.SP25.FinalProject.FloresV.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int RankId { get; set; }
        
        public virtual Member? Member { get; set; }
        public virtual Rank? Rank { get; set; }
    }
}
