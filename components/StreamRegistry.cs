using System;

namespace App
{
    public class SecureAdapter
    {
        private int _state;

        public SecureAdapter(int seed) => _state = seed;

        public int sync(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 87) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SecureAdapter(87);
            Console.WriteLine(obj.sync(87));
        }
    }
}
