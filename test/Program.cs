using _12122014EgitimKodlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            EFRepository<Catetgory> catRepo = new EFRepository<Catetgory>();
            SecurityDecorator<Catetgory> secDec = new SecurityDecorator<Catetgory>(catRepo);
            LogDecorator<Catetgory> logDec = new LogDecorator<Catetgory>(secDec);
            MailDecorator<Catetgory> mailDec = new MailDecorator<Catetgory>(logDec);
            CRMDecorator<Catetgory> crmDec = new CRMDecorator<Catetgory>(mailDec);


            crmDec.Add(new Catetgory());
            crmDec.Update(new Catetgory());
            crmDec.Delete(new Catetgory());
            crmDec.Get();
            Console.ReadLine();
        }
    }
}
