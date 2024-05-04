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