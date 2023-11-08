internal class Program
{
    private static List<string> items = new List<string> { "aa", "ab", "ba", "bb", "c" };

    private static void Main(string[] args)
    {
        Console.WriteLine("?");
        string input = Console.ReadLine();

        List<string> value = new List<string>();
        int i = 0;
        while (value.Count < 4)
        {
            if (input[i] == 'c')
            {
                value.Add("c");
                i += 1;
            }
            else
            {
                value.Add(input.Substring(i, 2));
                i += 2;
            }
        }

        foreach (string item in items)
        {
            if (!value.Contains(item))
            {
                Console.WriteLine(item);
                break;
            }
        }
    }
}