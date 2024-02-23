namespace MethodOverloading
{
    public class Program
    
        {
        public static int Add(int x, int y)
        {
            return x + y;

        }

        public static double Add(double x, double y)
        {
            return x + y;

        }
        public static decimal Add(decimal x, decimal y)

        {
            return x + y;

        }
        public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }

        }

        static void Main(string[] args)
        {
            var answer = Add(2, 2);
            Console.WriteLine(answer);

            var answer2 = Add(2.77, 2.88);
            Console.WriteLine(answer2);

            var answer3 = Add(0, 1, true);
            Console.WriteLine(answer3);

            var answer4 = Add(3, 4, true);
            Console.WriteLine(answer4);
        }
    }
}
