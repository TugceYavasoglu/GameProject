using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Tuğçe",
                LastName = "Yavaşoğlu",
                IdentityNumber = 12345
            });
        }
    }
}
