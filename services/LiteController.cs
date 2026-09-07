using System;

namespace App
{
    public class SmartCollector
    {
        private int _state;

        public SmartCollector(int seed) => _state = seed;

        public int run(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 18) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SmartCollector(18);
            Console.WriteLine(obj.run(18));
        }
    }
}
