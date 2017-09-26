using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StragetyPattern
{
    // 所得税计算策略
    public interface ITaxStragety
    {
        double CalculateTax(double income);
    }
    /// <summary>
    /// 个人所得税
    /// </summary>
    public class PersonalTaxStragety : ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
    /// <summary>
    /// 企业所得税
    /// </summary>
    public class EnterPriseTaxStragety : ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
        }
    }

    public class InterestOperation
    {
        private ITaxStragety m_stragety;
        public InterestOperation(ITaxStragety stragety)
        {
            this.m_stragety = stragety;
        }

        public double GetTax(double income)
        {
            return m_stragety.CalculateTax(income);
        }
    }
}
