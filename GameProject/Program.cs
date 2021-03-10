using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager manager = new GamerManager(new KullanıcıDoğrulama());
            manager.Add(new Gamer
            {
                
                BirthDay = 1998,
                FirstName = "Seko",
                LastName="Çortaoğlu",
                TcNo=12345

            });

        }
    }
}
