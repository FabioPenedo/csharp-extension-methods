using App.Extensions;

namespace App // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new(2024, 05, 15, 5, 25, 45);
            //Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(11));
        }
    }
}