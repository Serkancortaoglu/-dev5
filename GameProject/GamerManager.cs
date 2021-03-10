using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IKullanıcıDoğrulama _kullanıcıDoğrulama;
        public GamerManager(IKullanıcıDoğrulama kullanıcıDoğrulama)
        {
            _kullanıcıDoğrulama = kullanıcıDoğrulama;
        }
        public void Add(Gamer gamer)
        {
            if (_kullanıcıDoğrulama.Doğrulama(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
        

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
