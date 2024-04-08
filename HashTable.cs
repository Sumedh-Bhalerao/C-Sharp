using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Hashtable ht = new Hashtable();
        ht.Add(100, "Product 1");
        ht.Add(200, 4.5);
        ht.Add(300, 10);

        IDictionary keys = (IDictionary)ht.Keys;
        IDictionary dt1 = (IDictionary)ht.Values;

        foreach (object o in ht.Keys)
        {
            Console.WriteLine(o);
        }
        foreach (object o in ht.Values)
        {
            Console.WriteLine(o);
        }

        var cities = new Hashtable();
        {
            { "UK" , " London,Manchester,Birmingam"};
            { "USA", "Chicago,NewYork, Washington"};

         };

        string citiesOf UK = (string)cities["UK"];
    }
}
