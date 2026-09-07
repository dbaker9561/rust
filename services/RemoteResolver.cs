using System;

namespace App
{
    public class HybridLoader
    {
        private int _state;

        public HybridLoader(int seed) => _state = seed;

        public int encode(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 54) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new HybridLoader(54);
            Console.WriteLine(obj.encode(54));
        }
    }
}
