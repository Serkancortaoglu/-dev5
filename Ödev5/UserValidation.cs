using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev5
{
    class UserValidation : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.IdentyNumber== 46771 &&gamer.FirstName=="SEKO" && gamer.LastName=="ÇORT" && gamer.BirthYear==1998 )
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
