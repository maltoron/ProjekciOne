using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekciOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int dh = 6; //długość hasła
            Console.WriteLine($"Hasło musi zawierać conajmniej {dh} znaków");

            Console.WriteLine("Podaj Hasło");
            string haslo = Console.ReadLine(); 
            
            
            if (!haslo.Equals(string.Empty))
            {
                if (haslo.Length >= dh)
                {
                    Console.WriteLine("Podaj Hasło");
                    string hasloS = Console.ReadLine();

                    if (!hasloS.Equals(string.Empty))
                    {
                        // if (hasloS.Length >= dh)  // niekonieczne gdy haslo 1 jest powyzej 6 znaków
                        // {                         // i tak beda niezgodne z haslem
                        if (haslo == hasloS)
                        {
                            Console.WriteLine("Hasla zgodne");
                        }
                        else { Console.WriteLine("Hasla nie sa zgodne"); }
                        // }
                        // else { Console.WriteLine("Haslo powtorne za krotkie"); }
                    }
                   
                }
                else
                {
                    Console.WriteLine("Hasło za krótkie (min 6 znaków)");
                }
            }
            else { Console.WriteLine("Hasło nie moze być puste"); }

            Console.ReadLine();
        }
        
    }
}
