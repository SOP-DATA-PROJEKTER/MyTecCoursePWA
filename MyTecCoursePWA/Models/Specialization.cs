using MyTecCoursePWA.Interfaces;

namespace MyTecCoursePWA.Models
{
    public class Specialization : ISelectable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Course>? Courses { get; set; }
        public Pathway? Pathway { get; set; }
        public int PathwayId { get; set; }
    }
}
