using System;
public interface IShape
{
    double CalculateArea();
    bool IsValid();
}
public class Rectangle : IShape
{
    public double Width{get;set;}
    public double Height{get;set;}
    public Rectangle(double width,double height)
    {
        Width=width;
        Height=height;
    }
    public double CalculateArea()=>Width*Height;
    public bool IsValid()=>Width>0&&Height>0;
}
public class Square : IShape
{
    public double Side{get;set;}
    public Square(double side)
    {
        Side=side;
    }
    public double CalculateArea()=>Side*Side;

    public bool IsValid()=>Side>0;
}

public class Triangle : IShape
{
    public double Base{get;set;}
    public double Height{get;set;}

    public Triangle(double baseLength,double height)
    {
        Base=baseLength;
        Height=height;
    }
    public double CalculateArea()=>(Base*Height)/2;
    public bool IsValid()=>Base>0&&Height>0;
}
public class ShapeFactory
{
    public static IShape CreateShape(string type,params double[] dimensions)
    {
        switch(type.ToLower())
        {
            case "rectangle":
                return new Rectangle(dimensions[0],dimensions[1]);
            case "square":
                return new Square(dimensions[0]);
            case "triangle":
                return new Triangle(dimensions[0],dimensions[1]);
            default:
                throw new ArgumentException("Invalid shape type");
        }
    }
}
class Program
{
    static Random random=new Random();
    static void Main()
    {
        List<IShape> shapes=new List<IShape>();
        for(int i=0;i<10;++i)
        {
            string shapeType=random.Next(3)==0?"rectangle":random.Next(2)==0?"square":"triangle";
            double[] dimensions;
            Console.WriteLine($"Add a {shapeType}.");
            if(shapeType=="rectangle")
            {
                dimensions=new double[2]{random.Next(1,20),random.Next(1,20)};
            }
            else if (shapeType=="square")
            {
                dimensions=new double[1]{random.Next(1,20)};
            }
            else
            {
                dimensions=new double[2]{random.Next(1,20),random.Next(1,20)};
            }
            shapes.Add(ShapeFactory.CreateShape(shapeType,dimensions));
        }
        double totalArea=0;
        foreach(var shape in shapes)
        {
            if(shape.IsValid())
            {
                totalArea+=shape.CalculateArea();
            }
        }
        Console.WriteLine($"Total area:{totalArea}");
    }
}