using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Kredi;

namespace ChainOfResponsibility.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //önce yapılacak olan işlemlerin hepsi aynı listeye koyulur.
            List<CreditRequestBase> creditOperations = new List<CreditRequestBase>();
            //bütün işlemler listenin içerisine yerleştiriliyor.
            creditOperations.Add(new CheckKbbScore());
            creditOperations.Add(new CheckKreditCardPaymentTime());
            creditOperations.Add(new CheckGuarantorIsFine());
            creditOperations.Add(new CustomersEarningsIsEnoughToPayCredit());
            creditOperations.Add(new CheckCompanyCustomerWork());


            creditOperations[0].setNext(creditOperations[1]);
            creditOperations[1].setNext(creditOperations[2]);
            creditOperations[2].setNext(creditOperations[3]);
            creditOperations[3].setNext(creditOperations[4]);

            //krediyi isteyen müşterinin bilgilerini içeren sınıf paramtre olarak sisteme veriliyor
            //buradan sonra çorap söküğü gibi işlemler belirlenen sırada tekrarlınyor.
            creditOperations[0].Execute(new Customer());
            //son işlemden sonra son işlemin içerisinde bulunan ilgili property de istediğimiz
            //bilgi set edilmiş şekildedir.
            bool creditConfirmed=creditOperations[creditOperations.Count - 1].CreditConfirmed;

            if (creditConfirmed)
                Console.WriteLine("Kredi isteği onaylandı.");
            else
                Console.WriteLine("Kredi isteği reddedildi.");

            Console.ReadLine();
        }
    }
}
