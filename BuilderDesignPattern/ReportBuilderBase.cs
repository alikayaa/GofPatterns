using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    public abstract class ReportBuilderBase
    {
        protected ReportInfo Info;

        public ReportBuilderBase(ReportInfo reportInfo)
        {
            Info = reportInfo;
        }

        //opsiyonel.
        public string BuildOutput()
        {
            string output = BuildHeader();
            output += BuildContents();
            output += BuildFooter();
            return output;
        }

        public abstract string BuildHeader();
        public abstract string BuildFooter();
        public abstract string BuildContents();
    }
}
