using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Pattern
{
    // Singleton Mediator Yardımcı Sınıfı
    public class MediatorHelper
    {
        // Singleton için gerekli static değişken
        private static MediatorHelper _mediatorHelper;
        // Mediator Nesnesi
        public ConcreteMediator ChatRoom = new ConcreteMediator();
        // Yapıcı fonksiyon kapatılır.
        private MediatorHelper()
        {
           
        }
        // Örnek Alma
        public static MediatorHelper Instance()
        {
            if (_mediatorHelper == null)
                _mediatorHelper = new MediatorHelper();

            return _mediatorHelper;
        }
    }
}
