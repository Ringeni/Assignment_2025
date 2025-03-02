using System;
class Eratosthenes
{
    static int Main()
    {
        bool[] visit=new bool[102];
        Console.WriteLine("Primenumbers between 1~100:");
        for(int i=2;i<=100;++i)
        {
            if(visit[i]==false)
            {
                Console.WriteLine(i.ToString());
                for(int j=i+i;j<=100;j+=i)
                {
                    visit[j]=true;
                }
            }
        }
        return 0;
    }
}