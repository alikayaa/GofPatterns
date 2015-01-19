using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesignPattern
{
    /// <summary>
    /// Director
    /// </summary>
    public class ReportManager
    {
        private ReportBuilderBase Builder;
        public ReportManager(ReportBuilderBase builder)
        {
            Builder = builder;
        }

        public string Build()
        {
            string product = Builder.BuildOutput();
            return product;
        }
        //opsiyonel
        public string BuildUpsideDown()
        {
            string product = Builder.BuildFooter();
            product += Builder.BuildContents();
            product += Builder.BuildHeader();
            return product;
        }
    }
}
