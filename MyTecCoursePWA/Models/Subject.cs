using MyTecCoursePWA.Interfaces;

namespace MyTecCoursePWA.Models
{
    public class Subject : ISelectable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Milestone>? Milestones { get; set; } = new();
        public Course? Course { get; set; }
        public int CourseId { get; set; }
    }
}
