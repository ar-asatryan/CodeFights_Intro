using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4_AdjElProd
{
    class AdjElProd
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 13, 1, 72, 0, -9, 8, 33, 5};
            Console.WriteLine(AdjElProd.AdjacentElementsProduct(arr));
        }

        static int AdjacentElementsProduct(int[] inputArray)
        {
            int[] Prods = new int[inputArray.Length - 1];
            for (int i = 0; i < (inputArray.Length - 1); i++)
            {

                int product = inputArray[i] * inputArray[i + 1];
                Prods[i] = product;
            }

            return Prods.Max();
        }
    }
}
