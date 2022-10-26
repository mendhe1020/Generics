namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            FindMax<int> obj = new FindMax<int>(first, second, third);
            int Max=obj.FindMaxmum();

            Console.WriteLine("Max Num:" + Max);
        }
    }
}