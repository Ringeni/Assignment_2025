using System;
using System.Runtime.Serialization.Json;
class FindPrimeNum
{
    static int n;
    static int[] prime= new int[100002];
    static void Main()
    {
        string text;
        do
        {
            Console.WriteLine("Please enter an integer.");
            text=Console.ReadLine();
        }
        while(!int.TryParse(text,out n));
        int count=0;
        for(int i=2;i*i<=n;++i)
        {
            if(n%i==0)
            {
                ++count;
                prime[count]=i;
                while(n%i==0) n=n/i;
            }

        }
        if(n!=1)
        {
            ++count;
            prime[count]=n;
        }
        Console.WriteLine($"{count} numbers:");
        for(int i=1;i<=count;++i)
        {
            string now=prime[i].ToString();
            Console.WriteLine(now);
        }
        return;
    }
}