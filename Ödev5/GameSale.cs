using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev5
{
    class GameSale : IGameSale
    {
        
        public void Sale( Game game)
        {
            Console.WriteLine("{1} OYUNUN {0} Tl'ye satışı yapılmıstır ",game.Price,game.GameName);
        }
    }
}
