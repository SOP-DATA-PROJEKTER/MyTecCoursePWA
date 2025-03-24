using MyTecCoursePWA.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyTecCoursePWA.Services
{
    public class MockUserService
    {
        private readonly MockEducationService _educationService;
        private readonly List<User> _mockUsers;

        public MockUserService(MockEducationService educationService)
        {
            _educationService = educationService;

            // Sample user list
            _mockUsers = new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "John S. Johnson",
                    Email = "john@example.com",
                    Role = "Student",
                    EducationId = 100,
                    PathwayId = 200,
                    SpecializationId = 300,
                    CourseId = 401
                },
                new User
                {
                    Id = 2,
                    Name = "Alice M. Andersen",
                    Email = "alice@example.com",
                    Role = "Admin",
                    EducationId = 101,
                    PathwayId = 201,
                    SpecializationId = 301,
                    CourseId = 403
                }
            };

            // Assign education data
            foreach (var user in _mockUsers)
            {
                user.SetEducationData(_educationService.GetEducationList());
            }
        }

        public User GetUser() => _mockUsers.FirstOrDefault() ?? new User();

        public List<User> GetUserList() => _mockUsers;

        public void AddUser(User newUser)
        {
            newUser.Id = _mockUsers.Max(u => u.Id) + 1; // Assign new unique ID
            _mockUsers.Add(newUser);
            newUser.SetEducationData(_educationService.GetEducationList());
        }

        public void UpdateUser(User updatedUser)
        {
            var existingUser = _mockUsers.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Email = updatedUser.Email;
                existingUser.Role = updatedUser.Role;
                existingUser.EducationId = updatedUser.EducationId;
                existingUser.PathwayId = updatedUser.PathwayId;
                existingUser.SpecializationId = updatedUser.SpecializationId;
                existingUser.CourseId = updatedUser.CourseId;
                existingUser.SetEducationData(_educationService.GetEducationList());
            }
        }

        public void DeleteUser(int userId)
        {
            var user = _mockUsers.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _mockUsers.Remove(user);
            }
        }
    }
}
