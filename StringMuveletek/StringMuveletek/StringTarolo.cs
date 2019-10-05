using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMuveletek
{
    class StringTarolo
    {

        private string inputString;

        public StringTarolo(string inputString)
        {
            this.inputString = inputString;
        }

        public string atalakitottSzoveg() {

            string atalakitottSzoveg = null;
            

            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))                {
                    
                    atalakitottSzoveg += '*';
                }
                else
                {
                    atalakitottSzoveg += '?';
                }
            }
           
            return atalakitottSzoveg;
        }
    }
}
