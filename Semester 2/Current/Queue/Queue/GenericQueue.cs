using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class QueueGeneric<T> : IEmptyable, IPrintable, ICountable where T : IComparable 
    {
        public void Count()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        public void print()
        {

        }

        List<T> queue = new List<T>();

        public QueueGeneric() { }

        public void Enqueue(T val)
        {
            queue.Insert(0, val);
        }

        public T Dequeue()
        {
            T temp = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return temp;
        }

        public T Peek()
        {
            return queue[queue.Count - 1];
        }
    }
}
