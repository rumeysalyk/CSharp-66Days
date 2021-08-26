using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =1000,sum=0;
            
            for(int i=0;i<number;i++)
                if(i%3==0||i%5==0)
                    sum +=i;
                    
            Console.WriteLine(sum);

        }
    }
}
