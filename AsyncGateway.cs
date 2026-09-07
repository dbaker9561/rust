using System;

namespace App
{
    public class AsyncManager
    {
        private int _state;

        public AsyncManager(int seed) => _state = seed;

        public int flush(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 11) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new AsyncManager(11);
            Console.WriteLine(obj.flush(11));
        }
    }
}
