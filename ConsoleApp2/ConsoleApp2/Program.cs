using System;
using System.Collections.Generic;
/*public class Person
{
    public int Age { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public override string ToString() =>
$"Name: {FirstName} {LastName}, Age: {Age}";
}*/
class Program
{// ví dụ về List<T>
    static void Main(string[] args)
    {
        /*  List<Person> list = new List<Person>() {
          new Person { FirstName = "Duy", LastName = "Nang", Age = 21 },
          new Person { FirstName = "Duy", LastName = "Ky", Age = 21 },
          new Person { FirstName = "dai", LastName = "Nang", Age = 21 }
      };
          Console.WriteLine("Iterm in list: {0}", list.Count);
          foreach (Person p in list)
          {
              Console.WriteLine(p);
          }
          Console.ReadLine();
      }*/
        SortedSet<int> mySet = new SortedSet<int>() { 8, 7, 9, 1, 3 };
        // Ví dụ về SortedSet
        mySet.Add(5);
        mySet.Add(4);
        mySet.Add(6);
        mySet.Add(2);
        Console.WriteLine("Elements of mySet: \n");
        
        foreach (var val in mySet)
        {
            Console.Write($"{val,3}");
        }
        Console.ReadLine();
    }
}