using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportInfo info = new ReportInfo();
            info.Title = "Ektre";
            info.TotalCost = 100;
            info.Expenses = new List<string>();
            info.Expenses.Add("Alişveriş1");
            info.Expenses.Add("Alişveriş2");
            info.Expenses.Add("Alişveriş3");
            info.Expenses.Add("Alişveriş4");

            ReportBuilderBase builder = new XmlReportBuilder(info);
            ReportManager reportManager = new ReportManager(builder);

            string str = reportManager.BuildUpsideDown();
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
