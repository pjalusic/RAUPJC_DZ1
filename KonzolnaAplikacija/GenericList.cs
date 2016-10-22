using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolnaAplikacija
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int currentIndex;

        public GenericList ()
        {
            _internalStorage = new X[4];
            currentIndex = -1;
        }

        public GenericList (int initialSize)
        {
            if (initialSize > 0)
                _internalStorage = new X[initialSize];
            else
                throw new ArgumentException("Size must be greater than zero!");
            currentIndex = -1;
        }

        public int Count
        {
            get
            {
                return currentIndex + 1;
            }
        }

        public void Add(X item)
        {
            int size = _internalStorage.Length;
            if (currentIndex + 1 >= size)
            {
                X[] temp = new X[2 * size];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = _internalStorage[i];
                }
                _internalStorage = temp;
            }
            currentIndex++;
            _internalStorage[currentIndex] = item;
        }

        public void Clear()
        {
            currentIndex = -1;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i <= currentIndex; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public X GetElement(int index)
        {
            if (index <= currentIndex && index >= 0)
            {
                return _internalStorage[index];
            }
            throw new IndexOutOfRangeException("Index out of range!");
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i <= currentIndex; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(X item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index > currentIndex || index < 0)
            {
                return false;
            }
            for (int i = index; i < currentIndex; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            currentIndex -= 1;
            return true;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
