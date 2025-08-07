using System.Xml.Linq;

namespace Assignment5._4._2
{
    internal class Program
    {
        static void Squarearrray(int[,] arr)
        {
            int sum = 0;
            Console.WriteLine("The matrix is :");
         
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
                sum += arr[i, i];
            }
            Console.Write("Addition of the right Diagonal elements is: ");
            Console.Write(sum);
        }
        static void Main(string[] args)
        {
            Squarearrray(new int[,] { { 1, 2 },{ 3, 4 } });
        }
    }
}
