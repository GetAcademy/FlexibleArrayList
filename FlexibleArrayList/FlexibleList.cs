namespace FlexibleArrayList
{
    using System;

    namespace FlexibleArrayList
    {
        class FlexibleList<T>
        {
            private T[] _values = new T[2];
            public int Count { get; private set; } = 0;

            public int Add(T value)
            {
                if (Count >= _values.Length) IncreaseCapacity();
                _values[Count] = value;
                Count++;
                return Count;
            }

            public T Get(int index)
            {
                return _values[index];
            }

            public void Show()
            {
                for (var index = 0; index < Count; index++)
                {
                    var n = _values[index];
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }

            private void IncreaseCapacity()
            {
                var length = _values.Length;
                Console.WriteLine($"Øker kapasitet fra {length} til {length * 2}.");
                var newNumbers = new T[length * 2];
                Array.Copy(_values, newNumbers, length);
                _values = newNumbers;
            }
        }
    }

}
