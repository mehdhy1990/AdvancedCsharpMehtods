Console.WriteLine("hello world ");
var name = "Mehdi";
var name1 = name.REeverse();
Console.WriteLine(name);
public static class Extensionstring{

    public static string REeverse(this string s)
    {
        var reverseChar = s.Reverse<char>().ToArray();
        var reversed = new string(reverseChar);
        return reversed;
        
    }
}