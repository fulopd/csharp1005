using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMuveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg;
            Console.Write("Írj be valamit: ");
            szoveg = Console.ReadLine();
            Console.WriteLine(szoveg);
            StringTarolo st = new StringTarolo(szoveg);
            Console.WriteLine(st.atalakitottSzoveg());


            Console.ReadKey();


        }
    }
}
