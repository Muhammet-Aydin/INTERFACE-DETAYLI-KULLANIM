using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasıtKrediManager = new TasıtKredıManager();
            tasıtKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();
            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService fileloggerService = new FileLoggerService();

            Console.WriteLine("--------------------------------------------------+");
            basvuruManager.BasvuruYap(konutKrediManager,new DbLoggerService());
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileloggerService);
            basvuruManager.BasvuruYap(tasıtKrediManager,new SmsLoggerService());
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            Console.WriteLine("--------------------------------------------------+");

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.Read();
        }
    }
}
