using MyTecCoursePWA.Models;

namespace MyTecCoursePWA.Services
{
    public class MockEducationChoice
    {
        private readonly MockEducationService _mockEducation;

        public MockEducationChoice(MockEducationService mockEducation)
        {
            _mockEducation = mockEducation;
        }

        public MyEducationChoice GetMockEducationChoice()
        {
            var mockEducationList = _mockEducation.GetEducationList();

            if (mockEducationList == null || !mockEducationList.Any())
            {
                Console.WriteLine("MockEducationService returned an empty list!");
                return new MyEducationChoice();
            }

            foreach (var education in mockEducationList)
            {
                Console.WriteLine($"Education: {education.Name}");
            }

            var selectedEducation = mockEducationList.FirstOrDefault(e => e.Name == "EUD");
            if (selectedEducation == null)
            {
                Console.WriteLine("EUD education not found!");
                return new MyEducationChoice();
            }

            var selectedPathway = selectedEducation.Pathways.FirstOrDefault(p => p.Name == "Data og Kommunikation");
            if (selectedPathway == null)
            {
                Console.WriteLine("Pathway not found!");
                return new MyEducationChoice();
            }

            var selectedSpecialization = selectedPathway.Specializations.FirstOrDefault(s => s.Name == "Programmering");
            if (selectedSpecialization == null)
            {
                Console.WriteLine("Specialization not found!");
                return new MyEducationChoice();
            }

            return new MyEducationChoice
            {
                Id = 1,
                User = "user1",
                Education = selectedEducation!,
                Pathway = selectedPathway!,
                Specialization = selectedSpecialization!
            };
        }

    }
}
