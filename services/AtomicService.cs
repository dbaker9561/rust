using System;

namespace App
{
    public class AtomicContext
    {
        private int _state;

        public AtomicContext(int seed) => _state = seed;

        public int flush(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 26) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicContext(26);
            Console.WriteLine(obj.flush(26));
        }
    }
}
