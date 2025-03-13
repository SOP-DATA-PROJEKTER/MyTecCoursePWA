using MyTecCoursePWA.Models;

namespace MyTecCoursePWA.Services
{
    public class MockUserService
    {
        private readonly MockEducationService _educationService;
        private readonly User _mockUser;

        public MockUserService(MockEducationService educationService)
        {
            _educationService = educationService;

            _mockUser = new User
            {
                Id = 1,
                Name = "John S. Johnson",
                EducationId = 100,
                PathwayId = 200,
                SpecializationId = 300,
                CourseId = 401 
                //Praktikforløb 1 = 400
                //Hovedforløb 1  = 401
                //Praktikforløb 2 = 402
                //Hovedforløb 2 = 403
            };

            _mockUser.SetEducationData(_educationService.GetEducationList());
        }

        public User GetUser() => _mockUser;
    }
}
