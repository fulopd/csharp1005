using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class Program
    {   

        static void Main(string[] args)
        {
            List<NobelDij> NobelDijTarolo = new List<NobelDij>();
            StreamReader sr = new StreamReader("nobel.csv");

            sr.ReadLine(); //első sort ki akarom hagyni... Listába ne legyen feltöltve
            while (!sr.EndOfStream)
            {
                string[] item = sr.ReadLine().Split(';');

                NobelDij n = new NobelDij(Convert.ToInt32(item[0]), item[1], item[2], item[3]);
                NobelDijTarolo.Add(n);
            }

            sr.Close();

            Console.WriteLine("Elemek száma: " + NobelDijTarolo.Count);
            foreach (NobelDij item in NobelDijTarolo)
            {
                if (item.TeljesNev == "Arthur B. McDonald")
                {
                    Console.WriteLine(item.TeljesNev + " " + item.Tipus);
                }

                if (item.Evszam == 2017)
                {
                    Console.WriteLine("2017 ben kapott nóbelt: " + item.TeljesNev);
                }
                
            }

            Console.WriteLine("\nBéke nobelt kaptak (1990 - 2019):");
            foreach (NobelDij item in NobelDijTarolo)
            {
                if (item.Evszam < 2019 && item.Evszam > 1990)
                {
                    if (item.Tipus == "béke")
                    {
                        Console.WriteLine(item.TeljesNev + " " + item.Evszam + " " + item.Tipus);
                    }
                    
                }

                
            }


            Console.WriteLine("\n6. feladat:");
            Console.WriteLine("\nCurie család:");
            foreach (NobelDij item in NobelDijTarolo)
            {
                if (item.VezetekNev.Contains("Curie"))
                {
                    
                     Console.WriteLine(item.Evszam + ": " +item.TeljesNev);
                    

                }


            }


            Console.WriteLine("\n7. feladat:");
            HashSet<string> tipusok = new HashSet<string>();

            foreach (NobelDij item in NobelDijTarolo)
            {
                tipusok.Add(item.Tipus);

            }
            
            int[] darab = new int[tipusok.Count];

            foreach (NobelDij item in NobelDijTarolo)
            {
                int counter = 0;

                foreach (string tipus in tipusok)
                {
                    if (tipus == item.Tipus)
                    {
                        darab[counter]++;
                    }
                    counter++;
                }
            }

            int counter1 = 0;
            foreach (string item in tipusok)
            {
                Console.WriteLine(item + ": " + darab[counter1]);
                counter1++;
            }



            Console.WriteLine("\n8. feladat:");

            StreamWriter sw = new StreamWriter("orvosi.txt", false);

            foreach (NobelDij item in NobelDijTarolo)
            {
                if (item.Tipus == "orvosi")
                {
                    sw.WriteLine(item.TeljesNev + " " + item.Tipus);
                }

            }


            Console.WriteLine("File létrejött");

            Console.ReadKey();




        }

    
        
    }
}
