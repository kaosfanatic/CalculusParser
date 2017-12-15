using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string output = "0";

            return output;
        }


        static string Parse(string input)
        {
            string output = "";
            string temp = "";

            for (int i = 0; i < input.Length; i++)
            {

                if(input[i] == '+' || input[i] == '-')
                {
                    output = output + Parse(temp);
                }
                if(input[i] == '^')
                {
                    int j = i;

                    string coeff = "";

                    while (!Char.IsLetter(input[j]))
                    {
                        j--;
                    }
                    while (!Char.IsWhiteSpace(input[j]))
                    {
                        coeff = coeff + input[j];
                    }


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
