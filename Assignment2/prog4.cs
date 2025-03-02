using System;
class MatrixIdentify
{
    static int[,] mat;
    static int Main()
    {
        int n,m;
        string inStr;
        do
        {
            Console.WriteLine("please enter n");
            inStr=Console.ReadLine();
        }while(!int.TryParse(inStr,out n));
        do
        {
            Console.WriteLine("please enter m");
            inStr=Console.ReadLine();
        }while(!int.TryParse(inStr,out m));
        mat=new int [n+2,m+2];

        for(int i=1;i<=n;++i)
        {
            for(int j=1;j<=m;++j)
            {
                do
                {
                    Console.WriteLine($"please enter a[{i}][{j}]");
                    inStr=Console.ReadLine();
                }while(!int.TryParse(inStr,out mat[i,j]));
            }
        }
        bool result=true;
        for(int i=1;i<=n&&result;++i)
        {
            int currentNum=mat[i,1];
            for(int x=i,y=1;x<=n&&y<=m;++x,++y)
            {
                if(mat[x,y]!=currentNum)
                {
                    result=false;
                    break;
                }
            }
        }
        for(int i=1;i<=m&&result;++i)
        {
            int currentNum=mat[1,i];
            for(int x=1,y=i;x<=n&&y<=m;++x,++y)
            {
                if(mat[x,y]!=currentNum)
                {
                    result=false;
                    break;
                }
            }
        }
        if(result) Console.WriteLine("Yes");
        else Console.WriteLine("No");
        return 0;
    }
}