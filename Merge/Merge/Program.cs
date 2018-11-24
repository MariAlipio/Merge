using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge
{
    class Program
    {
        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> rigth = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                rigth.Add(unsorted[i]);
            }

            left = MergeSort(left);
            rigth = MergeSort(rigth);
            return Merge(left, rigth);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {

            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {

                if (left.Count > 0 && right.Count > 0)
                {

                    if (left.First() <= right.First())
                    {

                        result.Add(left.First());
                        left.Remove(left.First());

                    }
                    else
                    {

                        result.Add(right.First());
                        right.Remove(right.First());

                    }

                }
                else if (left.Count > 0)
                {

                    result.Add(left.First());
                    left.Remove(left.First());

                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());

                }

            }

            return result;

        }

        private static List<int> Resultado(List<int> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            return result;

        }

        static void Main(string[] args)
        {
            int[] arrMyValues = new int[] {5,3,6,1,8,9};
            List<int> vetor = new List<int>(arrMyValues);

            MergeSort(vetor);
            Console.ReadKey();
            //result é o sorted, como chamar ele?


            //Resultado(result);
            Console.ReadLine();




        }
    }
}
