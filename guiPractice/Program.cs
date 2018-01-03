using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace guiPractice
{ 

  
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            

           
        }


        static string MainDerive(string input)
        {
            string output = String.Empty;

            return output;
        }


        static string Parse(string input)
        {
            string output = String.Empty;
            string temp = String.Empty;
            string ptnExponent = @"(.*?)\1\^(\d)\2";      //Reads: any character, the '^', then an integer.  Stores the character and the integer.
            string ptnArithm = @"[(.*?) [\+\-]*]+?";    //Reads: any character, as many times as needed until a + or - (if it exists), then repeats until end.
            string ptnChain = @"\((.*?)\1\)";           //Reads; check for anything within parentheses, stores.
            string ptnSin = @"sin" + ptnChain;          //Reads: sin(chain)
            string ptnCos = @"cos" + ptnChain;          //Reads: cos(chain)
            string ptnTan = @"tan" + ptnChain;          //Reads: tan(chain)
            string ptnLog = @"log" + ptnChain;
            string ptnLn = @"ln" + ptnChain;
            string ptnE = @"e\^.";
            string ptnCoef = @"\d+?[a-z]";
            string ptnDivision = @"\((.+?)\)/\(?(.+?)\)?;";
            //Just realized this may not work, unless I force input to be formatted a certain way.
            //New method wouldn't use regular expressions for everything, will attempt over weekend.

            //First, separate functions joined with + or -.
            //Then, use multiplication/division to derive their factors, and adjust for exponents.

            for (int i = 0; i < input.Length; i++)
            {

                
                if(input[i] == '+' || input[i] == '-')
                {
                    output = output + Parse(temp);
                }
                

                temp = temp + input[i];
            }

            

            return output;
        }

        static string DeriveExponent(int coef, char var, int power)
        {
            string output = "0";
            

            return output;
        }

        static string DeriveCosine(int coef, string contained)
        {
            string output = "0";
            string derContained = Parse(contained);



            return output;
        }
    }

   
}
