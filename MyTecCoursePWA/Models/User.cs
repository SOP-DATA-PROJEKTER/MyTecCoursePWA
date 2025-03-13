using System.Collections.Generic;
using System.Linq;

namespace MyTecCoursePWA.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Store only the IDs
        public int EducationId { get; set; }
        public int PathwayId { get; set; }
        public int SpecializationId { get; set; }
        public int CourseId { get; set; }

        // Computed properties to fetch actual objects from the service
        public Education? SelectedEducation { get; private set; }
        public Pathway? SelectedPathway { get; private set; }
        public Specialization? SelectedSpecialization { get; private set; }
        public Course? SelectedCourse { get; private set; }

        public void SetEducationData(List<Education> educationList)
        {
            SelectedEducation = educationList.FirstOrDefault(e => e.Id == EducationId);
            SelectedPathway = SelectedEducation?.Pathways.FirstOrDefault(p => p.Id == PathwayId);
            SelectedSpecialization = SelectedPathway?.Specializations.FirstOrDefault(s => s.Id == SpecializationId);
            SelectedCourse = SelectedSpecialization?.Courses.FirstOrDefault(c => c.Id == CourseId);
        }
    }
}
