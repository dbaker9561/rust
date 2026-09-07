using System;

namespace App
{
    public class SharedMonitor
    {
        private int _state;

        public SharedMonitor(int seed) => _state = seed;

        public int render(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 58) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SharedMonitor(58);
            Console.WriteLine(obj.render(58));
        }
    }
}
