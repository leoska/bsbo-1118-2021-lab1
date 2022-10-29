using BSBO_1118_2021_lab1;
using  System;

// Queue, pointers, bubble sort
class Program
{


    static void Main(string[] args)
    {
        Queue queue = new Queue();
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            queue.Push(random.Next(1000));
        }

        queue.Print();

        bool flag = false;

        for (int i = 0; i < queue.size; i++)
        {
            flag = false;
            for (int j = 0; j < queue.size - i - 1; j++)
            {
                if (queue.Get(j) > queue.Get(j + 1))
                {
                    int p = queue.Get(j+1);
                    queue.Set(j+1, queue.Get(j));
                    queue.Set(j, p);
                    flag = true;
                }
            }
            //if (!flag) break;
        }
        Console.WriteLine('\n');
        queue.Print();
    }
}