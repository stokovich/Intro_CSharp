using System;

class LongSequence
{
    static void Main()
    {
        int num_member = 2;
        for (int i = 0; i < 1000; i++)
        {
            if (num_member % 2 == 0)
            {
                Console.WriteLine(num_member);
                num_member++;
            }
            else
            {
                Console.WriteLine(-num_member);
                num_member++;
            }
        }
    }
}
