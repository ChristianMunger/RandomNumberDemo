namespace RandomInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // a Random is a pseudo-random number
            // if we don't pass anything it will use current clock tick as a seed, then calculates number
            // so, if we know the seed we can kinda guess the random number
            // Random random = new Random(1); Notice this always returns the same order of random numbers
            // if something has to be absolutely random like passwords OR you need thread safety, use a cryptographic library
            // if just shuffling a list or something like that Random() is fine
            // Fisher-Yates shuffle is an efficient way to randomize a very large list, O(N) time complexity
            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.NextDouble()); // between 0 and 1, so can multiply by a constant like 10 to get between 0 and 10
                // SimpleMethod(random);
                // Console.WriteLine(random.Next(5, 11));  // numbers will be less than 11 and greater than or equal to 5
            }
            Console.ReadLine();
        }

        // how to pass random variable to a method
        private static void SimpleMethod(Random ran)
        {
            Console.WriteLine(ran.Next());
        }
    }
}