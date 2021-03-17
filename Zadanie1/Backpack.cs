using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Backpack
    {
        public Backpack(int capacity)
        {
            Capacity = capacity;
        }
        public int Capacity { get; }
        public int Load_value = 0;
        public int Actual_load = 0;
        public int Load_weights = 0;
        public void Load(List<int> index, List<int> values, List<int> weights)      // funkcja Load, w której sprawdzamy czy aktualna waga w plecaku plus nowa  
        {                                                                           // waga jest mniejsza od maksymalnej pojemności plecaka, gdy nie to aktualną
                                                                                    // wagę przypisujemy do wartości załadowwanej i tą wartość zwracamy
            foreach (int x in index)
            {

                if ((Actual_load += weights[x]) <= Capacity)
                {
                    Load_value += values[x];

                    System.Console.Write("\t");

                    System.Console.Write("\n");
                }
                else
                {
                    Actual_load -= weights[x];
                }
            }
            Load_weights = Actual_load;
        }
    }
}
