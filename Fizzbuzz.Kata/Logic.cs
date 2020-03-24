namespace Fizzbuzz.Kata
{
    public static class Logic
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public static string FizzBuzz = "FizzBuzz";

        public static string ToFizzbuzz(this int input)
        {
            if (input % 15 == 0)
            {
                return Logic.FizzBuzz;
            }
            if (input % 3 == 0)
            {
                return Logic.Fizz;
            }
            if (input % 5 == 0)
            {
                return Logic.Buzz;
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
