using System.Collections;

namespace Iterator;



class MyCollection : IEnumerable
{
    private readonly List<string> _colors = new();

    public void Add(string colorName)
    {
        _colors.Add(colorName);
    }

    public void Remove(string colorName)
    {
        _colors.Remove(colorName);
    }


    public IEnumerator GetEnumerator()
    {
        return _colors.GetEnumerator();
    }
}




class Program
{

    static void Main()
    {
        MyCollection collection = new();

        collection.Add("Red");
        collection.Add("Green");
        collection.Add("Blue");


        var iterator = collection.GetEnumerator();


        while (iterator?.MoveNext() ?? false)
            Console.WriteLine(iterator?.Current);


        iterator?.Reset();

    }
}