using System;

namespace FloatRangeChecker
{
    class Program
    {
        //task1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");

            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numbers[i] = num;
                }
                
            }

            bool allInRange = true;
            foreach (int num in numbers)
            {
                if (num <= -5 || num >= 5)
                {
                    allInRange = false;
                    break; 
                }
            }

            
            if (allInRange)
            {
                Console.WriteLine("All three numbers are in the range [-5.5]");
            }
            else
            {
                Console.WriteLine("Not all three numbers are in the range [-5.5]");
            }

            Console.ReadKey();



            //task2


            
            Console.WriteLine("Enter three integer numbers:");

            
            int max = int.MinValue; 
            int min = int.MaxValue; 

            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numb))
                {
                    max = Math.Max(max, numb);
                    min = Math.Min(min, numb);
                }
                
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
        
            Console.ReadKey();




            //task3

            Console.Write("Enter an HTTP error code: ");
            if (int.TryParse(Console.ReadLine(), out int errorCode))
            {
                if (Enum.IsDefined(typeof(HTTPError), errorCode))
                {
                    HTTPError error = (HTTPError)errorCode;
                    Console.WriteLine($"Error {errorCode}:{error} ");
                }
                else
                {
                    Console.WriteLine("Invalid HTTP error code.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadKey();


            //task4

            Console.WriteLine("Enter information for the dog:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Mark: ");
            string mark = Console.ReadLine();
            Console.Write("Age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                
                Dog myDog = new Dog(name, mark, age);

                
                Console.WriteLine("Dog Information:");
                Console.WriteLine(myDog.ToString());
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
            }



        }
        public struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            
            public Dog(string name, string mark, int age)
            {
                Name = name;
                Mark = mark;
                Age = age;
            }

            
            public override string ToString()
            {
                return string.Format($"Name: {Name}, Mark: {Mark}, Age: {Age}");
                
            }
        }




        //task3
        public enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
            
        }

    }
}