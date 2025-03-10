namespace MyTecCoursePWA.Models
{
    public class Milestone
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public Subject? Subject { get; set; }
        public int SubjectId { get; set; }
    }
}
