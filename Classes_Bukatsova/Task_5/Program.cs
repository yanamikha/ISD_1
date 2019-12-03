using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nick", "Kolya", "Pupkin", 21);
            user.ShowInfo();
        }
    }
    class User
    {
        string login;
        string firstName;
        string lastName;
        int age;
        readonly DateTime dateCreation;

        public int Age { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            dateCreation = DateTime.Now;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Hello, {lastName} {firstName}!\n\nYour login: {login}, age: {age}\n\nDate of registration:{dateCreation.ToShortDateString()}");
        }
    }
}
