using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolnaAplikacija
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int currentIndex;

        public IntegerList()
        {
            _internalStorage = new int[4];
            currentIndex = -1;
        }

        public IntegerList (int initialSize)
        {
            if (initialSize > 0)
                _internalStorage = new int[initialSize];
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

        public void Add(int item)
        {
            int size = _internalStorage.Length;
            if (currentIndex + 1 >= size)
            {
                int[] temp = new int[2 * size];
                for (int i = 0; i<size; i++)
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

        public bool Contains(int item)
        {
            for (int i = 0; i<=currentIndex; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index <= currentIndex && index >= 0)
            {
                return _internalStorage[index];
            }
            throw new IndexOutOfRangeException("Index out of range!");
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i <= currentIndex; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }            
            return -1;
        }

        public bool Remove(int item)
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
            for (int i = index; i<currentIndex; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            currentIndex -= 1;
            return true;
        }
    }
}
