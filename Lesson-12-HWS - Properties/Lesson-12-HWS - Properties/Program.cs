using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_HWS___Properties
{
    class Program
    {
        private int hour; 
        public int Hour { get { return hour; } set { hour = value + 1; } }//Without BackingField
        public int Day { get; set; }//With BackingField = day_BackingField
        private readonly string programName;
        public string ProgramName { get { return programName; } }

        public Program()
        {
            programName = "MyProg";
        }
        static void Main(string[] args)
        {
            string custName = "Mika";
            double[] sumLines = { 113.5, 159, 252, 999 };
            DateTime validDate = DateTime.Now.AddDays(4);
            Quotation quotation = new Quotation(custName,sumLines,validDate);
            //quotation.CustomerName = "newMika";
            //quotation.ValidUntil = quotation.ValidUntil.AddDays(3);
            quotation.SumLines[3] = 734;
            quotation.ChangeMainDetails("newMika",quotation.ValidUntil.AddDays(3));
            sumLines[3] = 144;

        }
    }
}
