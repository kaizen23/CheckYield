using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pobranie danych.");
            IEnumerable<int> data = PobierzDane();

            Console.WriteLine("Rozpoczęcie pętli.");
            foreach (int i in data)
            {
                Console.WriteLine("Odczyt wartości w pętli: {0}", i);
                if (i > 6)
                    break;
            }

            Console.WriteLine("Koniec programu.");
            Console.ReadLine();
        }

        private static IEnumerable<int> PobierzDane()
        {
            Console.WriteLine("Początek metody PobierzDane.");

            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Aktualna wartość: {0}", i);
                yield return i;
            }

            Console.WriteLine("Koniec metody PobierzDane.");
        }

        //private static IEnumerable<int> PobierzDane()
        //{
        //    Console.WriteLine("Początek metody PobierzDane.");

        //    List<int> list = new List<int>();

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("Aktualna wartość: {0}", i);
        //        list.Add(i);
        //    }

        //    Console.WriteLine("Koniec metody PobierzDane.");
        //    return list;

        //}

    }
}
