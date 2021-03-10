using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class UserManager : IUserServices
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.FirstName=="Serkan" && gamer.LastName=="Çortaoğlu" && gamer.IdentiytNumber==12345 && gamer.BirthDay==1998)
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
