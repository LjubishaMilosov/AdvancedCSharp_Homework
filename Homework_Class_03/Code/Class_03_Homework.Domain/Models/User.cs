//Create class User that will have 3 properties Id, Name, Age
namespace Class_03_Homework.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public User() {}
    }
}
