using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace today1204
{
    class Program
    {
        static void Arr1()
        {
            // int int int int ...
            // double double double ...
            int x = 1;
            // <type>[] arr_of_int
            // fixed size - adv dis

            // 1.
            //int[] arr_of_int = { 5, 8, 9, 20, 80, -10203, 29372348, 11111 };

            // 2.
            int[] arr_of_int = new int[8]; // --> all cells are zero -- [0, 0, 0, 0, 0, 0, 0, 0]
            arr_of_int[0] = 5;
            arr_of_int[1] = 8;
            arr_of_int[2] = 9;
            arr_of_int[3] = 20;
            arr_of_int[4] = 80;
            arr_of_int[5] = -10203;
            arr_of_int[6] = 29372348;
            arr_of_int[7] = 11111;


            //                   0, 1, 2,  3
            int y = 2;

            Console.WriteLine(arr_of_int[0]);
            Console.WriteLine($"array lenth is : {arr_of_int.Length}");
            Console.WriteLine(arr_of_int[3]);
            Console.WriteLine(arr_of_int[arr_of_int.Length - 1]);

            for (int i = 0; i < arr_of_int.Length; i++)
            {
                Console.WriteLine($"array in arr_of_int[{i}] (zero-based) value is : {arr_of_int[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Reverse...");
            for (int i = arr_of_int.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"array in arr_of_int[{i}] (zero-based) value is : {arr_of_int[i]}");
            }

            Console.WriteLine("===============================");
            double[] arr_of_double = { 4.9, -23.123123, 67.7, 1.12, 3.14, 0.9 };
            //                   0, 1, 2,  3


            Console.WriteLine($"array double length is : {arr_of_double.Length}");


            for (int i = 0; i < arr_of_double.Length; i++)
            {
                Console.WriteLine($"array in arr_of_double[{i}] (zero-based) value is : {arr_of_double[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Reverse...");
            for (int i = arr_of_double.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"array in arr_of_double[{i}] (zero-based) value is : {arr_of_double[i]}");
            }

            Console.WriteLine($"first item is {arr_of_double[0]}");
            Console.WriteLine($"last item is {arr_of_double[arr_of_double.Length - 1]}");
        }

        static int InputNumberFromUser(string message)
        {
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a number...");
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            return number;
        }

        static int InputNumberFromUserWithMessage(string message)
        {
            int number = 0;
            do
            {
                Console.WriteLine(message);
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            return number;
        }

        static int InputNumberFromUserInRange(string message, int min, int max)
        {
            int number = 0;
            do
            {
                Console.WriteLine(message);
            }
            while (int.TryParse(Console.ReadLine(), out number) == false || number < min || number > max);

            return number;
        }

        static void ReadAllArrayNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = InputNumberFromUserInRange($"Please enter grade for student #{i + 1} ...", 0, 100);
            }
        }

        static void Main(string[] args)
        {

            // read x grades of students
            // print avg
            // print all grades under 55
            // print all grades over 90

            //int grade1, grade2,grade3 

            //int[] gradesArray = { 1, 2, 3 };

            //int[] gradesArray = new int[10];
            int x;
            x = 1;
            int[] gradesArraygradesArray;

            int class_size = InputNumberFromUserInRange("Please enter class size", 2, 40);

            gradesArraygradesArray = new int[class_size];

            ReadAllArrayNumbers(gradesArraygradesArray);

            Console.WriteLine("=================================");
            Console.WriteLine($"class size is {class_size}");
            Console.WriteLine("Grades:");

            for (int i = 0; i < gradesArraygradesArray.Length; i++)
            {
                Console.WriteLine($"Student #{i+1} garde : {gradesArraygradesArray[i]}");
            }

            // calculate average
            int sum = 0;
            for (int i = 0; i < gradesArraygradesArray.Length; i++)
            {
                sum = sum + gradesArraygradesArray[i];
            }

            double avg = sum / Convert.ToDouble(gradesArraygradesArray.Length);
            Console.WriteLine($"average : {sum} / {gradesArraygradesArray.Length} = {avg}");

            // print grades under 55
            Console.WriteLine("grades under 55:");
            for (int i = 0; i < gradesArraygradesArray.Length; i++)
            {
                if (gradesArraygradesArray[i] < 55)
                    Console.WriteLine($"Student #{i + 1} garde  : {gradesArraygradesArray[i]}");
            }

            // print grades over 90
            Console.WriteLine("grades over 90:");
            for (int i = 0; i < gradesArraygradesArray.Length; i++)
            {
                if (gradesArraygradesArray[i] > 90)
                    Console.WriteLine($"Student #{i + 1} garde : {gradesArraygradesArray[i]}");
            }

        }
    }
}
