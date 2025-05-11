
using Class_03_and_04_Homework.Domain.Models;
namespace Class_03_and_04_Homework.Domain

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


        public static void PromptAndSearch()
        {
            Console.WriteLine("Enter search parameters:");

            Console.Write("ID (or 0 to ignore): ");
            int.TryParse(Console.ReadLine(), out int id);

            Console.Write("Name (or empty to ignore): ");
            string name = Console.ReadLine();

            Console.Write("Age (or 0 to ignore): ");
            int.TryParse(Console.ReadLine(), out int age);

            var results = UserDatabase.Search(id, name, age);

            if (results.Count == 0)
            {
                Console.WriteLine("No matching users found.");
            }
            else
            {
                Console.WriteLine("Search Results:");
                foreach (var user in results)
                {
                    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
                }
            }
        }
    }
}
