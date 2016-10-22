using System;
using System.Collections;
using System.Collections.Generic;

namespace KonzolnaAplikacija
{
    internal class GenericListEnumerator<X> : IEnumerator<X>
    {
        private GenericList<X> genericList;
        private int currentIndex;

        public GenericListEnumerator(GenericList<X> genericList)
        {
            this.genericList = genericList;
            currentIndex =-1;
        }

        public X Current
        {
            get
            {
                return genericList.GetElement(currentIndex);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (currentIndex+1 >= genericList.Count)
            {
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex =-1;
        }
    }
}