using Class_03_Homework.Domain.Models;
// Create static class UserDatabase that will contain a list of Users
// (create couple of users and add them to the list).
// Create method (or methods) Search() that will search the UserDatabase
// by Id, Name and Age and will return users as a result.
namespace Class_03_Homework.Domain
{
    public static class UserDatabase
    {
        private static List<User> users = new List<User>()

        {
            new User{ Id = 1, Name = "Kire Kirovski", Age = 30 },
            new User { Id = 2, Name = "Stefan Stefanovski", Age = 25 },
            new User{ Id = 3, Name = "Jovan Jovanovski", Age = 28 }
        };

        public static List<User> Search(int id = 0, string name = "", int age = 0)
        {
            List<User> result = new List<User>();

            foreach (User user in users)
            {
                bool matchesId = id == 0 || user.Id == id;
                bool matchesName = string.IsNullOrEmpty(name) || user.Name.ToLower().Contains(name.ToLower());
                bool matchesAge = age == 0 || user.Age == age;

                if (matchesId && matchesName && matchesAge)
                {
                    result.Add(user);
                }
            }

            return result;
        }
    }
}
