using System;

namespace App
{
    public class CoreContext
    {
        private int _state;

        public CoreContext(int seed) => _state = seed;

        public int run(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 74) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new CoreContext(74);
            Console.WriteLine(obj.run(74));
        }
    }
}
