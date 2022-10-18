using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            //addition
            int sum = a + b;
            Console.WriteLine($"a + b = {sum}");

            //subtraction
            int sub = a - b;
            Console.WriteLine($"a - b = {sub}");

            //multiplication
            int prod = a * b;
            Console.WriteLine($"a * b = {prod}");

            //division
            int div = a / b;
            Console.WriteLine($"a / b = {div}");

            //modulus
            int mod = a % b;
            Console.WriteLine($"a % b = {mod}");



            //exercise 2
            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());

            var circle = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle is {circle}");
        }
    }
}