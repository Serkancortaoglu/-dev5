using System;
using System.Collections.Generic;
using System.Text;

namespace Ödev5
{
    class CompanyName : ICompanyName
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("Kampanya EKLENDİ ");
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Kampanya güncellendi");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
