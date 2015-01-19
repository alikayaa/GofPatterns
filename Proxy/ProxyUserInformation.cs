using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyUserInformation:IUserInformation
    {
        //proxy sınıfı Subject i uygular ve içinde subject referansı barındırır.
        private BTKUserInformation _btkObject;
        private bool LoadRealObject = false;
        private string userInfo = string.Empty;
        private string GetUserInformationFromBTK()
        {
            // Uzak Nesneyi oluştur.
            _btkObject = new BTKUserInformation();
            try
            {
                // Uzak nesneden bilgileri çek.
                userInfo = _btkObject.GetUserInformation();
                // Uzak nesnenin yüklendiğini işaretle.
                LoadRealObject = true;
                return userInfo;
            }
            catch
            {
                LoadRealObject = false;
                return "";
            }
            
        }
        // Proxy üzerinden kullanıcı bilgisini alma.
        public string GetUserInformation()
        {
            string result = "";
            // Proxy üzerinde uzak nesne yok ise oluştur.
            if (_btkObject == null)
            {
               result=GetUserInformationFromBTK();
            }
            // Eğer uzak nesne oluşmamış ise üzerindeki bilgiyi gönder.
            if (!LoadRealObject)
                return userInfo;
            else
                return result;
        }

    }
}
