using System;

namespace AVL
{
    class Program
    {


        static void Main(string[] args)
        {

            int[] test = { 25, 15, 6, 3, 2, 7, 9 };
            Avl<int> avl = new Avl<int>();
            for (int i = 0; i < test.Length; i++)
            {
                avl.Insert(test[i]);
            }

            ;
        }
    }
}
