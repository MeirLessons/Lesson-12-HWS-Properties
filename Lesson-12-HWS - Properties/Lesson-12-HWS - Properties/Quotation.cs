using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_HWS___Properties
{
    class Quotation
    {
        public string CustomerName { get; private set; }
        public double[] SumLines { get; set; }
        public double DocSum 
        {
            get
            {
                double sumAllLines = 0;
                for (int i = 0; i < SumLines.Length; i++)
                {
                    sumAllLines += SumLines[i];
                }
                return sumAllLines;
            }
        }
        public DateTime ValidUntil { get; private set; }

        public Quotation(string customerName, double[] sumLines, DateTime validUntil)
        {
            CustomerName = customerName;
            SumLines = new double[sumLines.Length];
            for (int i = 0; i < sumLines.Length; i++)
            {
                SumLines[i] = sumLines[i];
            }
            //SumLines = sumLines;
            ValidUntil = validUntil;
        }

        public void ChangeMainDetails(string newCustomer, DateTime newDate)
        {
            CustomerName = newCustomer;
            ValidUntil = newDate;
        }
    }
}
