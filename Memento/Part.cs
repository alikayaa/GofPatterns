using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // Originator Nesne
    // Bölüm
    public class Part
    {
        // Bölüm özellikleri
        public string PartName { get; set; }
        public int PartLenght { get; set; }

        // Bölüm Check Point Oluşturma
        public PartMemento CheckPoint()
        {
            return new PartMemento{
                PartName = this.PartName,
                PartLength = this.PartLenght
            };
        }

        // Bölüm Check Point Yükleme
        public void LoadPart(PartMemento checkPoint)
        {
            this.PartName = checkPoint.PartName;
            this.PartLenght = checkPoint.PartLength;
        }


    }
}
