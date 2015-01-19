using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Part part1 = new Part();
            part1.PartName = "Bölüm 1";
            part1.PartLenght = 70;
            
            Console.WriteLine("Bölüm yüzde " +part1.PartLenght);
            PartManager partManager = new PartManager();
            partManager.partCheckPoint = part1.CheckPoint();
            Console.WriteLine("Check Point oluşturuldu.");
            part1.PartLenght = 0;
            Console.WriteLine("Bölüm başarısız oldu.");
            Console.WriteLine("Bölüm yüzde " + part1.PartLenght);
            part1.LoadPart(partManager.partCheckPoint);
            Console.WriteLine("Bölüm Check Point Yüklendi.");
            Console.WriteLine("Bölüm yüzde " + part1.PartLenght);
            Console.Read();

        }
    }
}
