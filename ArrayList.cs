using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ArrayList");

        ArrayList obj = new ArrayList();
        obj.Add(100);
        obj.Add(3.4);
        obj.Add("Student");
        obj.Add('A');
        obj.Add(true);
        obj.Add(5.6f);
        obj.Insert(0, 500);


        Console.WriteLine(obj.Capacity);
        Console.WriteLine(obj.Count);


        Console.WriteLine(obj);
        foreach (object o in obj)
        {
            Console.WriteLine(o);
        }


         //To Remove

        obj.Remove(500);
        foreach(object o in obj)
        {
            Console.WriteLine(0);
        }

        Console.WriteLine("Second Example");

        ArrayList obj1 = new ArrayList();
        obj1.Add(123);
        obj1.Add(5.6);

        obj.AddRange(obj1);
        foreach (object o in obj1)
        {
            Console.WriteLine(obj1[0]);
            Console.WriteLine(obj1[1]);
        }
    }
}
