using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static void Marstrip()
        {
            Console.WriteLine("WHAT, is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("WHAT, is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("WHAT, is the airspeed velocity of an unladen swallow?");
            string airSpeedVelocity = Console.ReadLine();
            Console.WriteLine("WHAT, is your favorite movie?");
            string favoriteMovie = Console.ReadLine();
            
            Console.WriteLine($"{userName} approached the group and asked What is your favorite color? Arthur replied {favoriteColor}. {userName} asked what is your favorite movie? Lancelot replied {favoriteMovie}. Finally, {userName} asked Sir Gwayne, the Fearless, what is the airspeed velocity of an unladen swallow? Sir Gwayne replied {airSpeedVelocity} and that was the end of Sir Gwayne, the Fearless.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Substract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)

        {
            int sum = 0;

            foreach(int number in numbers)
            {
            //sum = sum + number;   
            sum += number;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //Marstrip();
            //Console.WriteLine(Add(10, 10));
            //int addedNums = Add(10, 10);
            //Console.WriteLine(addedNums);
            //Console.WriteLine(Substract(10, 10));
            //Console.WriteLine(Divide(numOne: 10, numTwo: 10));
            //Console.WriteLine(Sum(10, 20));
        }
    }
}
