using System;

namespace App
{
    public class FastEngine
    {
        private int _state;

        public FastEngine(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 61) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new FastEngine(61);
            Console.WriteLine(obj.dispatch(61));
        }
    }
}
