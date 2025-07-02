using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GubolaAdam_D0JE27_ZH2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Koktel koktel = new Koktel("AdamKoktail", "osszetevok.txt");

            string AdamKoktail = koktel.ReceptNyomtatas();

            Console.WriteLine(AdamKoktail);
        }
    }
}
