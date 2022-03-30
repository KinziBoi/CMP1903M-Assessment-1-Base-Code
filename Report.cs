using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
       
        //eg.   public void outputConsole(List<int>)
        public void outputReport(List<int> vals)
        {
            Console.WriteLine("\nThe data Contained " + vals[0] + " Upper Case Letters \n");
            Console.WriteLine("The data Contained " + vals[1] + " Lower Case Letters \n");
            Console.WriteLine("The data contained " + vals[2] + " Sentences \n");
            Console.WriteLine("The data Contained " + vals[3] + " Vowels \n");
            Console.WriteLine("The data Contained " + vals[4] + " Consonants \n");
        }

    }
}
