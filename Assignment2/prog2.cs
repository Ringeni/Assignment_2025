using System;
class ArrayCalculate
{
    static int[] array;
    static int max(int x,int y)
    {
        return x>y?x:y;
    }
    static int min(int x,int y)
    {
        return x<y?x:y;
    }
    static int Main()
    {
        string inStr;
        int n;
        int sum=0;
        do
        {
            Console.WriteLine("please enter the size of the array.");
            inStr=Console.ReadLine();
        }while(!int.TryParse(inStr,out n));
        array=new int [n+2];
        for(int i=1;i<=n;++i)
        {
            do
            {
                Console.WriteLine($"please enter an integer, representing array[{i}].");
                inStr=Console.ReadLine();
            }while(!int.TryParse(inStr,out array[i]));
        }
        if(n==0)
        {
            Console.WriteLine("the array is empty!");
            return 0;
        } 
        Console.WriteLine($"the array has {n} numbers:");
        int maxNum=-2147483648,minNum=2147483647;
        for(int i=1;i<=n;++i)
        {
            maxNum=max(maxNum,array[i]);
            minNum=min(minNum,array[i]);
            sum+=array[i];
            Console.WriteLine(array[i].ToString());
        }
        double averageNum=(double)sum;
        averageNum/=(double)n;
        Console.WriteLine($"Max:{maxNum}");
        Console.WriteLine($"Min:{minNum}");
        Console.WriteLine($"Sum:{sum}");
        Console.WriteLine($"Average:{averageNum}");
        return 0;
    }
}