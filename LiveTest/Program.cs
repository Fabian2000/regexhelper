using RegExHelper;

namespace LiveTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Beispielverwendung der RegExBuilder-Klasse
            var regex = new RegExBuilder()
                .Start()
                .Text("Hello")
                .WhiteSpace()
                .OneOrMoreOfLastExpression()
                .Text("World")
                .End()
                .ToRegex();

            string input = "Hello     World";
            bool isMatch = regex.IsMatch(input);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Is Match: {isMatch}");
            Console.ReadKey(true);
        }
    }
}