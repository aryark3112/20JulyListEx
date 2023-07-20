using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20JulyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 21, 20, 3, 4, 55, 61 };
            Console.WriteLine("All numbers");
            Console.WriteLine("Total Number in list are :" + numbers.Count);
            Console.WriteLine("Capacity :" + numbers.Capacity);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            Console.WriteLine("total numbers in list are" + numbers.Count);
            Console.WriteLine("Capacity:" + numbers.Capacity);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Enter Number to search in list");
            int searchNumber = int.Parse(Console.ReadLine());
            if (numbers.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is a part of numbers list");
            }
            else { Console.WriteLine("Not found"); }
            Console.ReadKey();
        }
    }
}
