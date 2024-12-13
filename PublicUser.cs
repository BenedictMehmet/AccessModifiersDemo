using System;

namespace AccessModifiersDemo
{
    public class PublicUser
    {
        public string Name { get; set; }

        public PublicUser(string name)
        {
            Name = name;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Benutzername: {Name}");
        }
    }
}
