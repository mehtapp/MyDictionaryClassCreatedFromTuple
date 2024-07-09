
MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
//Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
Console.WriteLine("Başlangıç count : " + myDictionary.Count);
myDictionary.Add(1, "Mehtap");
myDictionary.Add(1000, "Kemal");
Console.WriteLine("Değer eklendi : " +myDictionary.Count);
Console.WriteLine("GÜncel Veriler");
foreach (var dictionary in myDictionary.GetDictionary())
{
    Console.WriteLine(dictionary.Item1 + " " + dictionary.Item2);
}
myDictionary.Clear();
Console.WriteLine("Liste boşaltıldı. " + myDictionary.Count);
Console.WriteLine("Teyit içindeki veriler");
foreach (var dictionary in myDictionary.GetDictionary())
{
    Console.WriteLine(dictionary.Item1 + " " + dictionary.Item2);
}


public class MyDictionary<K, V>  // K key için kullanılacak generic type'ı , K key için kullanılacak generic type'ı temsil eder.
{
    Tuple<K, V>[] _dictionary;
    Tuple<K, V>[] _tempDictionary;
    public MyDictionary()
    {
        _dictionary = new Tuple<K, V>[0];
    }
    private int _count;
    public int Count
    {
        get { return _count; }
    }
    public void Add(K key, V value)
    {
        _tempDictionary = new Tuple<K, V>[_dictionary.Length];
        _tempDictionary = _dictionary;
        _dictionary = new Tuple<K, V>[_dictionary.Length + 1];

        for (int i = 0; i < _tempDictionary.Length; i++)
        {
            _dictionary[i] = _tempDictionary[i];

        }
        _dictionary[_dictionary.Length-1] = Tuple.Create(key, value);
        _count = _dictionary.Length;
    }
    public void Clear() 
    {
        _dictionary = new Tuple<K, V>[0];
        _count = _dictionary.Length;
    }

    public Tuple<K, V>[] GetDictionary()
    {
        return _dictionary;
    }

}

