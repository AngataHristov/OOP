
namespace GenericList
{
    using System;
    using System.Text;

    [VersionAttribute("2","18")]
    public class MyGenericList<T>
    {
        private const int defaultCapacity = 16;

        private T[] array;
        private int capacity;

        public MyGenericList(int capacity = defaultCapacity)
        {
            this.Capacity = capacity;
            this.array = new T[capacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity cannot be negative value!");
                }

                this.capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
            set
            {
                if (index < 0 || index >= this.array.Length)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }

                this.array[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                ArrayResize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.array.Length; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.Count--;
        }

        public T ReturnElementByIndex(int index)
        {
            return this.array[index];
        }

        public void Clear()
        {
            this.array = new T[defaultCapacity];
        }

        public void Incert(T element, int index)
        {
            if (this.Count == this.Capacity)
            {
                ArrayResize();
            }

            for (int i = this.Count; i >= index; i--)
            {
                this.array[i] = this.array[i - 1];
            }

            this.array[index] = element;
            Count++;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            bool exist = false;

            for (int i = 0; i < this.Count; i++)
            {
                exist = this.array[i].Equals(element);
            }

            return exist;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.array[i]);
                result.Append(" ");
            }

            return result.ToString();
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new Exception("The list is empty");
            }
            else if (this.Count == 1)
            {
                return this.array[0];
            }
            else if (this.array[0] is IComparable<T>)
            {
                T min = this.array[0];

                for (int i = 0; i < this.Count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(this.array[i]) > 0)
                    {
                        min = this.array[i];
                    }
                }

                return min;
            }
            else
            {
                throw new InvalidOperationException("List is not comparable");
            }
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new Exception("The list is empty");
            }
            else if (this.Count == 1)
            {
                return this.array[0];
            }
            else if (this.array[0] is IComparable<T>)
            {
                T max = this.array[0];

                for (int i = 0; i < this.Count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(this.array[i]) < 0)
                    {
                        max = this.array[i];
                    }
                }

                return max;
            }
            else
            {
                throw new InvalidOperationException("List is not comparable");
            }
        }

        private void ArrayResize()
        {
            int newCapacity = this.Capacity * 2;
            T[] resizedArray = new T[this.Capacity * 2];

            for (int i = 0; i < this.Count; i++)
            {
                resizedArray[i] = this.array[i];
            }

            this.array = resizedArray;
            this.Capacity = newCapacity;
        }
    }
}
