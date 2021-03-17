using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Program
    {
        


        static void Main(string[] args)
        {

            //int Capacity = 50;
            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            List<int> index = new List<int>();                              //tworzenie list
            List<int> values = new List<int>();
            List<int> weights = new List<int>();

            Console.Write("Podaj pojemnosc plecaka: ");                     //podawanie pojemności plecaka
            int Capacity = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)                                    //wypełnianie list elementami
                index.Add(i);
            for (int j = 0; j < 10; j++)
                values.Add(rng.nextInt(1, 29));
            for (int k = 0; k < 10; k++)
                weights.Add(rng.nextInt(1, 29));

            Console.Write("Index: \t \t");
            foreach (int x in index)
            {
                System.Console.Write(x + " \t");
            }
            Console.WriteLine();

            Console.Write("Wartosc: \t ");
            foreach (int y in values)
            {
                System.Console.Write(y + "\t");
            }
            Console.WriteLine();

            Console.Write("Waga: \t \t");
            foreach (int z in weights)
            {
                System.Console.Write(z + "\t");
            }
            Console.WriteLine();
            var b1 = new Backpack(Capacity);
            Console.WriteLine();
            Console.WriteLine("Wybrana pojemnosc: " + b1.Capacity);
            b1.Load(index, values, weights);
            Console.Write("Waga: ");
            Console.WriteLine(b1.Load_weights);
            Console.WriteLine();
            Console.Write("Wartosc: ");
            Console.WriteLine(b1.Load_value);
            System.Console.ReadLine();
        }
    }

}
