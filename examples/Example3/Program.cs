using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 13195 ;
            bool flag = true;
            int max=0;

            for(int i=2;i<number;i++)
            {
                if(number%i==0)
                {
                    for(int j=2;j<i;j++)
                    {
                        if(i%j==0)
                        {
                            flag = false;
                            break;
                        }
    
                    }
                    if(flag==true)
                        max = i;
                }
            }

            Console.WriteLine(max);
        }
    }
}
