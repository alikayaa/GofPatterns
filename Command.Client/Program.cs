using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.DisabledEnabled;

namespace Command.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //invoker sınıfımızdan bir örnek alıp
            CommandManager commandManager = new CommandManager();

            //bankalar için receiverlarımız oluşturuldu.
            //ikisinin içerisinde de add ve delete metodu var.
            //ancak command nesnesi vasıtasıyla çağırılacak 
            ReceiverBank bank1 = new ReceiverBank("Banka 1");
            ReceiverBank bank2 = new ReceiverBank("Banka 2");

            //Birinci bankayı ekleme işlemine tabi tutmak için 
            //BankAddCommand sınıfından örnek oluşturuyoruz
            //İkinci bankayı silmek için BankDeleteCommand dan
            //örnek oluşturuyoruz. Ancak henüz çalıştırmadık.
            ICommand addBankCommand = new BankAddCommand(bank1);
            ICommand deleteBankCommand = new BankDeleteCommand(bank2);

            //supplierlar için receiverlarımız oluşturuldu.
            //ikisinin içerisinde de enable ve disable metodu var.
            //ancak command nesnesi vasıtasıyla çağırılacak
            ReceiverSupplier supplier1 = new ReceiverSupplier(1, "Supplier 1");
            ReceiverSupplier supplier2 = new ReceiverSupplier(2, "Supplier 2");

            //Birinci supplier ı aktif etme işlemine tabi tutmak için 
            //EnabledSupplierCommand sınıfından örnek oluşturuyoruz
            //İkinci supplier'ı pasif etmek için DisableSupplierCommand dan
            //örnek oluşturuyoruz. Ancak henüz çalıştırmadık.
            ICommand enableSupplierCommand = new EnabledSupplierCommand(supplier1);
            ICommand disableSupplierCommand = new DisableSupplierCommand(supplier2);


            //Bütün komutlar commandmanager'a ekleniyor.
            commandManager.Commands.Push(addBankCommand);
            commandManager.Commands.Push(deleteBankCommand);
            commandManager.Commands.Push(enableSupplierCommand);
            commandManager.Commands.Push(disableSupplierCommand);


            //artık çalıştırabiliriz
            commandManager.ExecuteAll();

            Console.ReadLine();
        }
    }
}
