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
                                                    Name = "Praktisk oplæring i virksomheden 1",
                                                    Description = "Eleven kan føre simple opgaver hvor dataudstyr anvendes",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 600, Description = "Eleven skal selvstændigt kunne fremstille små enkle programmer med et programmeringssprog." },
                                                        new Milestone { Id = 601, Description = "Eleven skal kunne anvende et programmeringsværktøj til udvikling af programmer." },
                                                        new Milestone { Id = 602, Description = "Eleven skal kunne anvende et versionsstyringsværktøj til at gemme og hente programmer." },
                                                        new Milestone { Id = 603, Description = "Eleven skal kunne håndtere forskellige talsystemer og benytte disse i forbindelse med f.eks. IP-adresser." }
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
                                                    Name = "Grundlæggende programmering",
                                                    Description = "I faget Grundlæggende programmering lærer du at designe, planlægge og udvikle mindre konsolprogrammer baseret på givne krav.",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 604, Description = "Lærlingen kan selvstændigt designe, planlægge og udvikle et mindre konsolprogram baseret på en case-opgave og opfylde de stillede krav." },
                                                        new Milestone { Id = 605, Description = "Lærlingen kan anvende et programmeringssprog til at udarbejde mindre konsolprogrammer." },
                                                        new Milestone { Id = 606, Description = "Lærlingen kan vælge en hensigtsmæssig datatype til en opgave." }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 502,
                                                    Name = "Objektorienteret programmering",
                                                    Description = "Er under udarbejdelse (maj/2022)",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 607, Description = "Er under udarbejdelse (maj/2022)" }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 503,
                                                    Name = "Databaseprogrammering. Niv. Avanceret TBD",
                                                    Description = "Eleven kan udarbejde et avanceret databasedesign, og anvende SQL syntaxen og ORM (Object Relational Mapping) til at opbygge databaser, suppleret af en tilhørende dokumentation.\n\nFaget på H1 omhandler SQL syntaxen og forståelsen af opbygningen af en relationel database, herunder dokumentation af relationstyper mellem tabeller vha. E/R-diagram. Der anvendes Microsoft SQL-Server og Microsoft SQL Server Management Studio.",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 608, Description = "Er under udarbejdelse." }
                                                    }
                                                }
                                            }
                                        },
                                        new Course
                                        {
                                            Id = 402,
                                            Name = "Praktikforløb 2",
                                            Subjects = new List<Subject>
                                            {
                                                new Subject
                                                {
                                                    Id = 504,
                                                    Name = "Praktisk oplæring i virksomheden 2",
                                                    Description = "Eleven kan designe, opbygge og implementere mindre databaseløsninger.",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 609, Description = "Eleven kan udvikle mindre console-programmer med fokus på OOP, såsom C# og webapplikationer, der benytter HTML og CSS." },
                                                        new Milestone { Id = 610, Description = "Virtualisering af udviklingsmiljø i fx Docker." }
                                                    }
                                                }
                                            }
                                        },
                                        new Course
                                        {
                                            Id = 403,
                                            Name = "Hovedforløb 2",
                                            Subjects = new List<Subject>
                                            {
                                                new Subject
                                                {
                                                    Id = 505,
                                                    Name = "Objektorienteret programmering. Niv. Rutineret",
                                                    Description = "Der arbejdes med komplekse objektorienterede begreber som call-back functions/delegates, overloading og overriding af metoder, interfaces osv. Undervisningen indeholder både konsolprogrammer og grafiske programmer. Faget indgår i \"4-ugers projektet\" og sættes i samspil med databaseteknologi samt grafiske udviklingsværktøjer for at udvikle en hel applikation.",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 611, Description = "Lærlingen kan oprette og vedligeholde databaser." },
                                                        new Milestone { Id = 612, Description = "Lærlingen kan udvikle API'er til backend-systemer." }
                                                    }
                                                },
                                                new Subject
                                                {
                                                    Id = 506,
                                                    Name = "Webudvikling og frontend",
                                                    Description = "Lærlingen udvikler dynamiske webapplikationer med moderne frameworks.",
                                                    Milestones = new List<Milestone>
                                                    {
                                                        new Milestone { Id = 613, Description = "Lærlingen kan skabe responsive brugergrænseflader." },
                                                        new Milestone { Id = 614, Description = "Lærlingen kan arbejde med REST API'er til frontend-integration." }
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
                    Description = "Studenterhue og Svendebrev",
                    Pathways = new List<Pathway>()
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
