using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Core;

namespace Prototype.Entity
{
    [Serializable]
    public class Product : Core.ICloneable, ICopyable, ICustomClonable
    {
        public Brand Brand;
        public string Name { get; set; }
        public int ProductID { get; set; }

        public object Clone()
        {
            return CloneHelper.Clone(this);     //deep copy our
        }

        public object Copy()
        {
            return MemberwiseClone();       //deep copy .net
        }

        public object CustomClone()
        {
            Product p = (Product)this.Copy();
            //p.Brand. vs..
            return p;       //custom copy logic here.
        }
    }
}
