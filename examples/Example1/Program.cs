using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =10,sum=0;
            
            for(int i=0;i<number;i++)
            {

                if(i%15==0)
                {
                    sum +=i;
                    continue;
                }
                else if(i%3 == 0)
                    sum +=i;
                else if(i%5 == 0)
                    sum +=i;
            }

            Console.WriteLine(sum);

        }
    }
}
