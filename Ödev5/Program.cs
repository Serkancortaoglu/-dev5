using System;

namespace Ödev5
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidation());
            gamerManager.Add(new Gamer
            {
                IdentyNumber=46771,
                FirstName="SEKO",
                LastName="ÇORT",
                BirthYear=1998
            });

            GameSale gameSale = new GameSale();
            gameSale.Sale(new Game
            {
                GameName = "PES",
                Price=70

            }) ;

            CompanyName companyName = new CompanyName();
            companyName.Update(new Sale
            {
                OrderId = 1
            }) ;

        }
    }
}
