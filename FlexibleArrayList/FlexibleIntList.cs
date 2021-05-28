using System;

namespace FlexibleArrayList
{
    class FlexibleIntList
    {
        int[] _numbers = new int[2];
        int _count = 0;

        public int AddNumber(int number)
        {
            if (_count >= _numbers.Length) IncreaseCapacity();
            _numbers[_count] = number;
            _count++;
            return _count;
        }

        public void Show()
        {
            for (var index = 0; index < _count; index++)
            {
                var n = _numbers[index];
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        private void IncreaseCapacity()
        {
            var length = _numbers.Length;
            Console.WriteLine($"Øker kapasitet fra {length} til {length * 2}.");
            var newNumbers = new int[length * 2];
            Array.Copy(_numbers, newNumbers, length);
            _numbers = newNumbers;
        }
    }
}
