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
                                        },
                                        new Course
                                        {
                                            Id = 401,
                                            Name = "Hovedforløb 1",
                                            Subjects = new List<Subject>
                                            {
                                                new Subject
                                                {
                                                    Id = 501,
                                                    Name = "Programmering 1",
                                                    Description = "Eleven kan anvende et programmeringssprog til at løse enkle opgaver",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 602, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 603, Description = "Eleven skal kunne anvende et programmeringssprog til at løse enkle opgaver." }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 502,
                                                    Name = "Programmering 2",
                                                    Description = "Eleven kan anvende et programmeringssprog til at løse mere komplekse opgaver",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 604, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 605, Description = "Eleven skal kunne anvende et programmeringssprog til at løse mere komplekse opgaver." }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 503,
                                                    Name = "Programmering 3",
                                                    Description = "Eleven kan anvende et programmeringssprog til at løse komplekse opgaver",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 606, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 607, Description = "Eleven skal kunne anvende et programmeringssprog til at løse komplekse opgaver." }
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        },
                        new Pathway
                        {
                            Id = 201,
                            Name = "Design og Produktion",
                            Specializations = new List<Specialization>
                            {
                                new Specialization
                                {
                                    Id = 301,
                                    Name = "Design",
                                    Courses = new List<Course>
                                    {
                                        new Course
                                        {
                                            Id = 401,
                                            Name = "Praktikforløb 1",
                                            Subjects = new List<Subject>
                                            {
                                                new Subject
                                                {
                                                    Id = 501,
                                                    Name = "Praktisk oplæring i virksomheden",
                                                    Description = "Eleven kan føre simple opgaver hvor dataudstyr anvendes",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 601, Description = "Eleven skal selvstændigt kunne fremstille små enkle programmer med et programmeringssprog." },
                                                        new Milestone { Id = 602, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." }
                                                    }
                                                }
                                            }
                                        },
                                        new Course
                                        {
                                            Id = 402,
                                            Name = "Hovedforløb 1",
                                            Subjects = new List<Subject>
                                            {
                                                new Subject
                                                {
                                                    Id = 502,
                                                    Name = "Design 1",
                                                    Description = "Eleven kan anvende et programmeringssprog til at løse enkle opgaver",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 602, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 603, Description = "Eleven skal kunne anvende et programmeringssprog til at løse enkle opgaver." }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 503,
                                                    Name = "Design 2",
                                                    Description = "Eleven kan anvende et programmeringssprog til at løse mere komplekse opgaver",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 604, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 605, Description = "Eleven skal kunne anvende et programmeringssprog til at løse mere komplekse opgaver." }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 504,
                                                    Name = "Design 3",
                                                    Description = "Eleven kan anvende et programmeringssprog til at løse komplekse opgaver",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 606, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 607, Description = "Eleven skal kunne anvende et programmeringssprog til at løse komplekse opgaver." }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new Education
                {
                    Id = 101,
                    Name = "EUX",
                    Description = "Studentereksamen Med Svendebrev",
                    Pathways = new List<Pathway>
                    {

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
