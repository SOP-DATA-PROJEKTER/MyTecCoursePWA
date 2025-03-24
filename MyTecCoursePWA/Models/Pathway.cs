using MyTecCoursePWA.Interfaces;

namespace MyTecCoursePWA.Models
{
    public class Pathway: ISelectable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Specialization>? Specializations { get; set; } = new();
        public Education? Education { get; set; }
        public int EducationId { get; set; }
    }
}
