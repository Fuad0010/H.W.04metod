using System;

namespace Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daxil edin: ");
            Console.WriteLine(Sum(Convert.ToInt32(Console.ReadLine())));



            string info = PersonInformation("Fuad", "Topchiev", 19);
            Console.WriteLine(info);

            Console.WriteLine(Muq(8, 5));

            int[] array = { 1, 2, 3, 4, 5, 6, };
            int result = massive(array);
            Console.WriteLine(result);


            Console.WriteLine(cixma(52));


            Console.WriteLine(End(4));
            End(array);


        }
        static int Sum(int num1, int num2 = 5)
        {
            return (num1 + num2);
        }

        static string PersonInformation(string name, string surname, int age)
        {
            return $"{name} {surname} {age}";
        }

        static int Muq(int a, int b)
        {
            if (a < b)
            {
                return a - b;
            }
            else
            {
                return b + a;
            }
        }

        static void Komprance(int num)
        {
            if (num > 7)
            {
                Console.WriteLine(num);
                return;
            }
            Console.WriteLine("test");


        }

        static int massive(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;

            }
            return sum;
        }

        static int cixma(int number1, int number2 = 12)
        {
            return number1 - number2;
        }


        


        /*
         metod signature

        1. metodun adi
        2. metodun parametrinin sayi
        3. metodun parametrlerinin typy-i
         */

        static int End (params int [] arr)
        {
            return 4;

        }
        static int End ()
        {
            return 2 ;
        }




    }
}
