using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first=1, second=2 ,temp, sum=0;

            while(first + second <= 4000000)
            {
                if(first % 2 ==0)
                {
                    Console.WriteLine("first--------------------- : " + first);
                    sum +=first;
                }
                Console.WriteLine(first + " : " + second);
                temp = first;
                first =second;
                second = temp + second;

            }
            Console.WriteLine("sum: "+ sum);

            if(first%2==0)
                sum += first;
            else if(second%2==0)
                sum += second;
            Console.WriteLine(first + " : " + second);

            Console.WriteLine("sum: "+ sum);

        }
    }
}
