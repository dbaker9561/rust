using System;

namespace App
{
    public class RemoteFactory
    {
        private int _state;

        public RemoteFactory(int seed) => _state = seed;

        public int flush(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 26) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new RemoteFactory(26);
            Console.WriteLine(obj.flush(26));
        }
    }
}
