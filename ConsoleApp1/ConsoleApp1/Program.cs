using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class MyClass<T> {
    // ví dụ về generic class
    private T data;
    public T Value { 
    get => data;
    set => data = value;
        }
public override string ToString() => $"Value: {data}";
        }
class Program
{
    static void Main(string[] args)
    {
        MyClass<string> name = new MyClass<string>()
        { Value = "Nang"};
        Console.WriteLine(name);
        MyClass<float> version = new MyClass<float>()
        { Value = 5.5f};
        Console.WriteLine(version);
        dynamic obj = new { Id = 1, Name = "Ky" };
        MyClass<dynamic> myClass = new MyClass<dynamic>() { Value = obj };
        Console.WriteLine(myClass);
        Console.ReadLine();

    }
}

interface IBasic<T> where T : struct
{// vi du generic interface
    T Add(T a, T b);
}


class MyFirstClass : IBasic<int>
{
    public int Add(int a, int b) => a + b;
}

class MySecondClass : IBasic<double>
{
    public double Add(double a, double b) => a + b;

}
class Program1
{
    static void Main(string[] args)
    {
        MyFirstClass firstClass = new MyFirstClass() ;
        dynamic r = firstClass.Add(1, 2) ;
        Console.WriteLine(r);
        MySecondClass secondClass= new MySecondClass() ;
        r = secondClass.Add(1.5, 2.5);
        Console.WriteLine(r);
        Console.ReadLine();
    }
}
