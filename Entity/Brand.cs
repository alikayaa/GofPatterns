using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Core;

namespace Prototype.Entity
{
    [Serializable]
    public class Brand : ICopyable
    {
        public string BrandName;
        public int BrandID;
        public object Copy()
        {
            return this.MemberwiseClone();
        }
    }
}
