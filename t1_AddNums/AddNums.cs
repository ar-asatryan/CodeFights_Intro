using System;

namespace t1_AddNums
{
    class AddNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"summa of Nums: {AddNums.Add(4, 9)}");
        }


        static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
