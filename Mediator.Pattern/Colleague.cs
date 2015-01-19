using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Pattern
{
    // Soyut aracı olunacak sınıf
    public abstract class Colleague
    {
        // Mediator Sınıfı
        private ConcreteMediator _concreteMediator;
        private string _name;
        public Colleague(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return this._name; }
        }

        public ConcreteMediator concreteMediator
        {

            set { _concreteMediator = value; }

            get { return _concreteMediator; }

        }


    }
}
