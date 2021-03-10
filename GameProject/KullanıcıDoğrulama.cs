using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KullanıcıDoğrulama : IKullanıcıDoğrulama
    {
        public bool Doğrulama(Gamer gamer)
        {
            if (gamer.BirthDay == 1998 && gamer.FirstName == "Seko" && gamer.LastName == "Çortaoğlu" && gamer.TcNo == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
