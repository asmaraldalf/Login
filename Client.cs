using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LoginClient
{
    class Client
    {
        static void Main()
        {
            Person person = new Person();

            Console.WriteLine("username: ");
            person.Username = Console.ReadLine();
            Console.WriteLine("password: ");
            person.Password = Console.ReadLine();

            string fileName = "UserData.json";
            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }

    class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
