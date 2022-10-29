using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBO_1118_2021_lab1
{
    internal class Queue
    {
        private Item? head = null;
        private Item? tail = null;
        public int size = 0;

        public void Push(int value)
        {
            Item? item = new Item(value, null);
            if (head == null) {
                head = item;
            };
            
            if (tail != null)
            {
                tail.next = item;                
            }
            tail = item;
            size++;
        }


        public int Pop()
        {
            if (head == null)
            {
                throw new Exception("Queue is empty!!!");
            }
            int val = head.value;
            head = head.next;
            if (size == 1)
            {
                tail = null;

            }
            size--;

            return val;
        }

        public int Get(int index)
        {
            for (int i = 0; i < index; i++) 
            {
                Push(Pop());
            }
            int val = head.value;
            for (int i = index; i < size; i++) 
            {
                Push(Pop());
            }
            return val;
        }
        public void Set(int index, int newValue)
        {
            for (int i = 0; i < index; i++)
            {
                Push(Pop());
            }
            head.value = newValue;
            for (int i = index; i < size; i++)
            {
                Push(Pop());
            }
        } 
        public void Print()
        {
            Item current = head;
            while (current != null)
            {
                Console.Write(" " + current.value);
                current = current.next;
            }
        }
    }
}
