using MyTecCoursePWA.Interfaces;

namespace MyTecCoursePWA.Models
{
    public class Course : ISelectable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Subject>? Subjects { get; set; } = new();
        public Specialization? Specialization { get; set; }
        public int SpecializationId { get; set; }
    }
}
