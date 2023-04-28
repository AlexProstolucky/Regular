using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input the password to check: ");
        string checker = @"([a-z\d{3,}]){9}";
        Regex reg = new Regex(checker);
        string buf = Console.ReadLine();
        Console.WriteLine(reg.IsMatch(buf));
    }
}