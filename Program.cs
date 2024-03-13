using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 5, 2, 7, 1, 9 };

            BubbleSort(numbers);

            Console.WriteLine("Sıralanmış :");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;




                    }
                }
                 
            }
        }


    }
      
    }
