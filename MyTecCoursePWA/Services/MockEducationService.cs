using MyTecCoursePWA.Models;


namespace MyTecCoursePWA.Services
{
    public class MockEducationService
    {
        private readonly List<Education> _educationList;

        public MockEducationService()
        {
            _educationList = new List<Education>
        {
            new Education
            {
                Id = 100,
                Name = "EUD",
                Description = "Erhvervsuddannelser",
                Pathways = new List<Pathway>
                {
                    new Pathway
                    {
                        Id = 200,
                        Name = "Data og Kommunikation",
                        Specializations = new List<Specialization>
                        {
                            new Specialization
                            {
                                Id = 300,
                                Name = "Programmering",
                                Courses = new List<Course>
                                {
                                    new Course
                                    {
                                        Id = 400,
                                        Name = "Praktikforløb 1",
                                        Subjects = new List<Subject>
                                        {
                                            new Subject
                                            {
                                                Id = 500,
                                                Name = "Praktisk oplæring i virksomheden",
                                                Description = "Eleven kan føre simple opgaver hvor dataudstyr anvendes",
                                                Milestones = new List<Milestone>
                                                {
                                                    new Milestone { Id = 600, Description = "Eleven skal selvstændigt kunne fremstille små enkle programmer med et programmeringssprog." },
                                                    new Milestone { Id = 601, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
        }

        public List<Education> GetEducationList()
        {
            return _educationList;
        }

        public Education? GetEducationByName(string name)
        {
            return _educationList.FirstOrDefault(e => e.Name == name);
        }
    }
}
