using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    public class DivBasedReportBuilder : ReportBuilderBase
    {
        public DivBasedReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
        }

        public override string BuildHeader()
        {
            return string.Format("<h1>{0}</h1>", this.Info.Title);
        }

        public override string BuildFooter()
        {
            return string.Format("<h5>{0}</h5>", this.Info.TotalCost);
        }

        public override string BuildContents()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var expense in base.Info.Expenses)
            {
                sb.Append(string.Format("<div class='contentItem'>{0}</div>", expense));
            }
            return sb.ToString();
        }
    }
}
