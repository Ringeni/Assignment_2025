using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("input the first number：");
        string firstStr=Console.ReadLine();
        double num1=Convert.ToDouble(firstStr);
        Console.WriteLine("select (+, -, *, /)：");
        string opt=Console.ReadLine();
        Console.WriteLine("input the second number：");
        string secondStr=Console.ReadLine();
        double num2=Convert.ToDouble(secondStr);
        double result=0;
        switch(opt)
        {
            case "+": result=num1+num2;break;
            case "-": result=num1-num2;break;
            case "*": result=num1*num2;break;
            case "/":
                if(num2!=0) result=num1/num2;
                else
                {
                    Console.WriteLine("error:divided by 0.");
                    return;
                }
                break;
            default:
                Console.WriteLine("invalid option.");
                return;
        }
        Console.WriteLine($"the result is：{result}");
    }
}