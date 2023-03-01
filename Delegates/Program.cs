namespace Delegates
{
    public class Program
    {
        delegate int StringLength(string str);

        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "cherry", "date" };

            StringLength stringLength = s => s.Length;

            foreach (string word in words)
            {
                int length = stringLength(word);
                Console.WriteLine($"{word}: {length}");
            }
        }
    }
}