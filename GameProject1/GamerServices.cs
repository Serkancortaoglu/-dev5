using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class GamerServices : IGamerServices
    {
        IUserServices _userServices;
        public GamerServices(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public void Add(Gamer gamer)
        {
            if (_userServices.Validation(gamer) == true)
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Dogrulama başarısız");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
