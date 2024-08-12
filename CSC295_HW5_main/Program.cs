namespace CSC295_HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Stack<char> chars = ParaChecker.createStack("(HelloWorld!)");
            Console.WriteLine(  chars.Peek());
            Console.WriteLine(ParaChecker.IsBalanced(chars));
        }
        
    }
}
