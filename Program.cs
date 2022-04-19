using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8DersDictionary // Dictionariler sorted list gibidir. Fark olarak, elemanlar oldugu gibi listeye eklenirler, sıralanmazlar...
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sozluk = new Dictionary<string, int>();
            sozluk.Add("Zehra", 15);
            sozluk.Add("Ahmet", 25);
            sozluk.Add("Hasan", 35);
            sozluk.Add("Fatih", 45);

            foreach (var item in sozluk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
