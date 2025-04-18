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
            Console.WriteLine("WHAT, is your favorie movie?");
            string favoriteMovie = Console.ReadLine();
            
            Console.WriteLine($"{userName} approached the group and asked What is your favorite color? Arthur replied {favoriteColor}. {userName} asked what is your favorite movie? Lancelot replied {favoriteMovie}. Finally, {userName} asked Sir Gwayne, the Fearless, what is the airspeed velocity of an unladen swallow? Sir Gwayne replied {airSpeedVelocity} and that was the end of Sir Gwayne, the Fearless.");
        }
        static void Main(string[] args)
        {
            Marstrip();
        }
    }
}
