using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    public class XmlReportBuilder : ReportBuilderBase
    {
        public XmlReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
        }

        public override string BuildHeader()
        {
            return string.Format("<Header>{0}</Header>", base.Info.Title);
        }

        public override string BuildFooter()
        {
            return string.Format("<Footer>{0}</Footer>", base.Info.TotalCost);
        }


        public override string BuildContents()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var expense in base.Info.Expenses)
            {
                 sb.Append(string.Format("<Expense name='{0}'/>", expense));
            }
            return sb.ToString();
        }
    }
}
