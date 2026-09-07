using System;

namespace App
{
    public class StreamProvider
    {
        private int _state;

        public StreamProvider(int seed) => _state = seed;

        public int handle(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 82) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new StreamProvider(82);
            Console.WriteLine(obj.handle(82));
        }
    }
}
