using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stack.CustomExceptions;

namespace Stack
{
    class Stack<T>
    {
        private T[] stackArray;
        private int maximumLength;

        public int Size { get; private set; }

        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }

        public void Push(T value)
        {
            if (Size == maximumLength)
                throw new ExceededSizeException();


            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

           return  stackArray[Size--];
        }

        public T Peek()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }

            return stackArray[Size - 1];
        }
    }
}
