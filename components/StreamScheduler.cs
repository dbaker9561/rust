using System;

namespace App
{
    public class AsyncController
    {
        private int _state;

        public AsyncController(int seed) => _state = seed;

        public int parse(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 38) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new AsyncController(38);
            Console.WriteLine(obj.parse(38));
        }
    }
}
