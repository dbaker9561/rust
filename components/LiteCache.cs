using System;

namespace App
{
    public class FastController
    {
        private int _state;

        public FastController(int seed) => _state = seed;

        public int encode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 61) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new FastController(61);
            Console.WriteLine(obj.encode(61));
        }
    }
}
