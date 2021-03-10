using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev5
{
    class GamerManager : IGamerManager
    {
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer)==(true))
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("Added False ");
            }
          
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
