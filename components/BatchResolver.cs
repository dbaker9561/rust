using System;

namespace App
{
    public class FastClient
    {
        private int _state;

        public FastClient(int seed) => _state = seed;

        public int parse(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 42) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new FastClient(42);
            Console.WriteLine(obj.parse(42));
        }
    }
}
