using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class BasvuruManager
    {
        //mettot ınjectıon
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //basvuran bilgileri degerlerndirme

            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var item in krediler)
            {
                item.Hesapla();
            }

        }
    }
}
